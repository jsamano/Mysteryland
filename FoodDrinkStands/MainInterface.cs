using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace FoodDrinkStands
{
    public partial class MainInterface : Form
    {
        private Client client;
        private Assistant assistant;
        private Shop shop;
        private Basket basket;
        private DataTable dataTable;
        private ContextMenu m;
        private RFID rfid;
        private InvoiceSearch invoiceSearchForm;
        string lastTag = "";
        public MainInterface(int shopID, int assistantID)
        {
            InitializeComponent();
            assistant = new Assistant(assistantID);
            shop = new Shop(shopID);
            this.Text = shop.Name + " - " + this.Text;
            lblShopName.Text = shop.Name;
            lblAssistantName.Text = assistant.Name;
            basket = new Basket();
            CreateTable();
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new RFIDTagEventHandler(rfid_Tag);
            rfid.TagLost += new RFIDTagLostEventHandler(rfid_TagLost);
            rfid.Open();
        }

        private void CreateTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int)).ReadOnly = true;
            dataTable.Columns.Add("Name", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Description", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Price", typeof(decimal)).ReadOnly = true;
            dataTable.Columns.Add("Quantity", typeof(int));
            DGVItems.DataSource = dataTable;
        }
        void rfid_Attach(object sender, AttachEventArgs e)
        {
            lblTag.Text = "-";
            lblStatus.Text = "Connected";
            lblSerialNumber.Text = rfid.DeviceSerialNumber.ToString();

            cbAntenna.Checked = rfid.AntennaEnabled;
            cbAntenna.Enabled = true;
            Console.Beep(2000, 150);
            Console.Beep(2500, 150);
            Console.Beep(3000, 150);
        }
        void rfid_Detach(object sender, DetachEventArgs e)
        {
            lblTag.Text = "-";
            lblStatus.Text = "Not Connected";
            lblSerialNumber.Text = "-";

            cbAntenna.Checked = false;
            cbAntenna.Enabled = false;
            Console.Beep(3000, 150);
            Console.Beep(2500, 150);
            Console.Beep(2000, 150);
        }
        void rfid_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Description);
            Console.Beep(4000, 300);

            rfid.Close();
        }
        void rfid_Tag(object sender, RFIDTagEventArgs e)
        {
            lblTag.Text = e.Tag;
            if (client == null)
            {
                client = Client.FindUser(e.Tag);
                if (client != null)
                {
                    Console.Beep(1500, 100);
                    Console.Beep(2000, 100);
                    UpdateClientInfo();
                    EnableActions(true);
                    lastTag = e.Tag;
                }
                else
                {
                    DirectMessage.ShowError("Invalid visitor RFID code.");
                }
            }
            else
            {
                if (client != null && e.Tag != lastTag && lblTag.Text != "-")
                {
                    Product p = shop.FindProductByRFIDCode(e.Tag);
                    if (p != null)
                    {
                        Product productToAdd = new Product(p.ID, 1, p.Price);
                        if (basket.FindProduct(p.ID) == null)
                        {
                            if (p.Quantity - 1 < 0) MessageBox.Show("Insufficient available quantity.");
                            else
                            {
                                Console.Beep(2000, 200);
                                basket.AddProduct(productToAdd);
                                dataTable.Rows.Add(p.ID, p.Name, p.Description, p.Price, 1);
                                UpdateNetAmount();
                            }
                        }
                        else
                        {
                            if (p.Quantity - basket.FindProduct(p.ID).Quantity - 1 < 0) MessageBox.Show("Insufficient available quantity.");
                            else
                            {
                                Console.Beep(2000, 200);
                                basket.IncrementingAddProduct(productToAdd);
                                DGVItems.Rows[DGVItems.Rows.Count - 1].Cells[4].Value = Convert.ToInt32(DGVItems.Rows[DGVItems.Rows.Count - 1].Cells[4].Value) + 1;
                                UpdateNetAmount();
                            }
                        }
                    }
                    else
                    {
                        string messageBoxText = "Another client ID is read. Do you want to change it?";
                        string caption = "New client ID read";
                        MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;
                        DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                Client newClient = Client.FindUser(e.Tag);
                                if (newClient != null)
                                {
                                    client = newClient;
                                    EnableActions(true);
                                    lastTag = e.Tag;
                                    break;
                                }
                                else
                                {
                                    DirectMessage.ShowError("Invalid visitor RFID code. Current client not changed.");
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void UpdateClientInfo()
        {
            lblClientCaption.Visible = true;
            lblClientName.Text = client.Name;
        }
        void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            lblTag.Text = "-";
        }

        private void cbAntenna_CheckedChanged(object sender, EventArgs e)
        {
            rfid.AntennaEnabled = cbAntenna.Checked;
        }

        private void RFIDStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Attach -= new AttachEventHandler(rfid_Attach);
            rfid.Detach -= new DetachEventHandler(rfid_Detach);
            rfid.Error -= new ErrorEventHandler(rfid_Error);
            rfid.Tag -= new RFIDTagEventHandler(rfid_Tag);
            rfid.TagLost -= new RFIDTagLostEventHandler(rfid_TagLost);

            rfid.Close();
            rfid = null;
        }
        private void MainInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(invoiceSearchForm != null) invoiceSearchForm.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSetClientNo_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Client(Convert.ToInt32(tbxClientNo.Text));
                if (client.Name != "")
                {
                    EnableActions(true);
                }
                else
                {
                    EnableActions(false);
                    MessageBox.Show("Client with that client number does not exist.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid client No format.");
            }
        }

        private void EnableActions(bool b)
        {
            if (b == true)
            {
                lblClientCaption.Visible = true;
                lblClientName.Text = client.Name;
                tbxClientNo.Text = client.ID.ToString();
                tbxClientNo.Enabled = false;
                btnSearch.Enabled = btnAdd.Enabled = btnFinalize.Enabled = btnRemove.Enabled = btnClear.Enabled = true;
                btnSetClientNo.Enabled = false;
            }
            else
            {
                btnPrint.Enabled = btnSearch.Enabled = btnAdd.Enabled = btnFinalize.Enabled = false;
                if (dataTable.Rows.Count == 0) btnRemove.Enabled = btnClear.Enabled = false;
                else btnRemove.Enabled = btnClear.Enabled = true;
                lblClientCaption.Visible = false;
                lblClientName.Text = "";
                tbxClientNo.Text = "";
                tbxClientNo.Enabled = true;
                btnSetClientNo.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxResult.Items.Clear();
            if (rbtnProductCode.Checked)
            {
                if (tbxSearchQuery.Text != "")
                {
                    try
                    {
                        Product p = shop.FindProductByCode(Convert.ToInt32(tbxSearchQuery.Text));
                        if (p == null)
                        {
                            MessageBox.Show("Product not found.");
                        }
                        else
                        {
                            lbxResult.Items.Add(p);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Incorrect input format.");
                    }
                }
                else
                {
                    MessageBox.Show("You have to input a code for search.");
                }
            }
            else if (rbtnProductName.Checked)
            {
                if (tbxSearchQuery.Text != "")
                {
                    try
                    {
                        List<Product> result = shop.FindProductByName(tbxSearchQuery.Text);
                        if (result.Count == 0)
                        {
                            MessageBox.Show("No products found.");
                        }
                        else
                        {
                            foreach (Product p in result)
                            {
                                lbxResult.Items.Add(p);
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Incorrect input format.");
                    }
                }
                else
                {
                    MessageBox.Show("You have to input a name for search.");
                }
            }
            else if (rbtnProductDescription.Checked)
            {
                if (tbxSearchQuery.Text != "")
                {
                    try
                    {
                        List<Product> result = shop.FindProductByDescription(tbxSearchQuery.Text);
                        if (result.Count == 0)
                        {
                            MessageBox.Show("No products found.");
                        }
                        else
                        {
                            foreach (Product p in result)
                            {
                                lbxResult.Items.Add(p);
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Incorrect input format.");
                    }
                }
                else
                {
                    MessageBox.Show("You have to input a description for search.");
                }
            }
            else
            {
                if (tbxSearchQuery.Text != "")
                {
                    try
                    {
                        List<Product> result = shop.FindProduct(tbxSearchQuery.Text);
                        if (result.Count == 0)
                        {
                            MessageBox.Show("No products found.");
                        }
                        else
                        {
                            foreach (Product p in result)
                            {
                                lbxResult.Items.Add(p);
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Incorrect input format.");
                    }
                }
                else
                {
                    MessageBox.Show("You have to input a search query.");
                }
            }
        }

        private void lbxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbxResult.SelectedIndex != -1)
            {
                Product p = ((Product)lbxResult.SelectedItem);
                MessageBox.Show("Code: " + p.ID + "\nName: " + p.Name + "\nDescription: " + p.Description + "\nPrice: " + p.Price + "\nQuantity available: " + p.Quantity);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxResult.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a product to add.");
            }
            else
            {
                Product p = (Product)lbxResult.SelectedItem;
                int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                if (p.Quantity - quantity < 0) MessageBox.Show("Insufficient available quantity.");
                else if (!basket.AddProduct(new Product(p.ID, quantity, p.Price))) MessageBox.Show("Item has already been added.");
                else
                {
                    dataTable.Rows.Add(p.ID, p.Name, p.Description, p.Price, numericUpDownQuantity.Value);
                    UpdateNetAmount();
                }
            }
        }

        private void UpdateNetAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < DGVItems.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(DGVItems.Rows[i].Cells[3].Value) * Convert.ToInt32(DGVItems.Rows[i].Cells[4].Value);
            }
            tbxNetAmount.Text = sum.ToString("N2");
        }

        private void DGVItems_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                m = new ContextMenu();
                int currentMouseOverRow = DGVItems.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0) m.MenuItems.Add(new MenuItem("Delete", DeleteRow_Click));
                m.Show(DGVItems, new Point(e.X, e.Y));
            }
        }
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            int rowToDelete = DGVItems.CurrentCell.RowIndex;
            basket.RemoveProduct(Convert.ToInt32(DGVItems.CurrentRow.Cells[0].Value));
            DGVItems.Rows.RemoveAt(rowToDelete);
            DGVItems.ClearSelection();
            UpdateNetAmount();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DGVItems.SelectedCells.Count > 0) DeleteRow_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            basket = new Basket();
            tbxNetAmount.Text = "0.00";
        }

        private void DGVItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateNetAmount();
            basket.BasketProducts[e.RowIndex].Quantity = Convert.ToInt32(DGVItems[e.ColumnIndex, e.RowIndex].Value);
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'ml_shop_bill';", helper.GetConnection());
                helper.Open();
                MySqlDataReader ReceiptReader = command.ExecuteReader();
                //command.Parameters.AddWithValue("@field", validField);
                if (ReceiptReader.Read())
                {
                    id = Convert.ToInt32(ReceiptReader["AUTO_INCREMENT"]);
                }
            }
            if (basket.BasketProducts.Count >= 1)
            {
                try
                {
                    if (shop.FinalizeReceipt(new Receipt(id, new Shop(shop.ID), new Client(client.ID), new Assistant(assistant.ID), basket, Convert.ToDecimal(tbxNetAmount.Text))))
                    {
                        for (int i = 0; i < lbxResult.Items.Count; i++)
                        {
                            lbxResult.Items[i] = lbxResult.Items[i];
                        }
                        MessageBox.Show("Successfully completed.");
                        PrintReceipt();
                        client = null;
                        EnableActions(false);
                        btnPrint.Enabled = true;
                    }
                    else DirectMessage.ShowError("Something went wrong with the transaction.");
                }
                catch (InsufficientBalanceException ex)
                {
                    DirectMessage.ShowError(ex.Message);
                }
            }
            else DirectMessage.ShowError("There are no products added.");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            invoiceSearchForm = new InvoiceSearch(shop, assistant);
            invoiceSearchForm.Show();
        }

        private void rbtnRFIDReader_CheckedChanged(object sender, EventArgs e)
        {
            //pnlBarcodeScanner.Visible = false;
            //pnlRFIDReader.Visible = true;

            pnlBarcodeScanner.SendToBack();
            pnlRFIDReader.BringToFront();
        }

        private void rbtnBarcodeScanner_CheckedChanged(object sender, EventArgs e)
        {
            //pnlRFIDReader.Visible = false;
            //pnlBarcodeScanner.Visible = true;

            pnlRFIDReader.SendToBack();
            pnlBarcodeScanner.BringToFront();
        }

        private void btnResetClientNumber_Click(object sender, EventArgs e)
        {
            client = null;
            EnableActions(false);
        }

        private void DGVItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    int value = Convert.ToInt32(e.FormattedValue);
                    if (value < 1)
                    {
                        DirectMessage.ShowError("Quantity cannot be less than 1.");
                        e.Cancel = true;
                    }
                    else
                    {
                        if (shop.FindProductByCode(Convert.ToInt32(DGVItems.CurrentRow.Cells[0].Value)).Quantity - value < 0)
                        {
                            string error = "Quantity cannot exceed available quantity.";
                            DirectMessage.ShowError(error);
                            DGVItems.Rows[e.RowIndex].ErrorText = error;
                            e.Cancel = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    DirectMessage.ShowError("This is not a quantity number.");
                    e.Cancel = true;
                }
            }
        }

        private void btnPreviousBill_Click(object sender, EventArgs e)
        {
            btnHistory_Click(sender, e);
            invoiceSearchForm.LoadReceipt(shop.GetLastReceipt());
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK) printDocument.Print();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Receipt receipt = shop.GetLastReceipt();
            int id = receipt.ID;
            string shopName = receipt.Shop.Name;
            decimal totalPrice = receipt.Amount;
            string assistant = receipt.Assistant.Name;
            string client = receipt.Client.Name + " (#ID: " + receipt.Client.ID + ")";
            string date = receipt.Date.ToString();
            string receiptInfo = shop.ToString() + "(#ID: " + id + ")";

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12);
            Font smallFont = new Font("Courier New", 10);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(receiptInfo, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            offset = offset + (int)fontHeight;
            graphic.DrawString("Client: " + client.PadRight(23) + "Assistant: " + assistant + "".PadRight(5), smallFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 15;
            graphic.DrawString("".PadLeft(28) + "Date: " + date, smallFont, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 15;
            string top = "Item".PadRight(25) + "Quantity".PadRight(15) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight;
            graphic.DrawString("---------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            foreach (Product item in receipt.ReceiptItems)
            {
                string product = item.Name;
                string price = item.Price.ToString();
                string quantity = item.Quantity.ToString();

                graphic.DrawString(product.PadRight(25) + "x " + quantity.PadRight(14) + price, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5;
            }

            offset = offset + 20;

            graphic.DrawString("Total paid: ".PadRight(40) + String.Format("{0:c}", totalPrice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 60;
            graphic.DrawString("   Thank you for your visit to Mysteryland,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please let us know how we did at", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("                mysteryland.nl", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
