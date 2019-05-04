using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace FoodDrinkStands
{
    public partial class InvoiceSearch : Form
    {
        private Shop shop;
        private Assistant assistant;
        private Receipt selectedReceipt;
        private DataTable dataTable;
        public InvoiceSearch(Shop shop, Assistant assistant)
        {
            InitializeComponent();
            this.shop = shop;
            this.assistant = assistant;
            CreateTable();
            UpdateLastInvoices();
            lbxLastInvoices.KeyUp += HandleKeyUpSelected;
        }

        private void HandleKeyUpSelected(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) lbxLastInvoices_DoubleClick(sender, e);
        }

        private void UpdateLastInvoices()
        {
            lbxLastInvoices.Items.Clear();
            foreach (Receipt r in this.shop.GetLastReceipts(10))
            {
                lbxLastInvoices.Items.Add(r);
            }
            lblLastUpdate.Text = DateTime.Now.ToString();
        }

        private void CreateTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int)).ReadOnly = true;
            dataTable.Columns.Add("Name", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Description", typeof(string)).ReadOnly = true;
            dataTable.Columns.Add("Price", typeof(decimal)).ReadOnly = true;
            dataTable.Columns.Add("Refund quantity", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int)).ReadOnly = true;
            DGVItems.DataSource = dataTable;
        }

        private void lbxLastInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            string strTip = "";
            int nIdx = lbxLastInvoices.IndexFromPoint(e.Location);
            if ((nIdx >= 0) && (nIdx < lbxLastInvoices.Items.Count)) strTip = lbxLastInvoices.Items[nIdx].ToString();
            toolTip1.SetToolTip(lbxLastInvoices, strTip);
        }
        public void LoadReceipt(Receipt r)
        {
            dataTable.Clear();
            foreach (Product p in r.ReceiptItems)
            {
                dataTable.Rows.Add(p.ID, p.Name, p.Description, p.Price, 0, p.Quantity);
            }
            lblID.Text = r.ID.ToString();
            lblClient.Text = r.Client.Name + " (" + r.Client.ID + ")";
            tbxNetAmount.Text = r.Amount.ToString();
            lblAssistant.Text = r.Assistant.Name.ToString();
            lblDate.Text = r.Date.ToString();
            lblInvoiceNo.Text = r.ID.ToString();
            lblIDCaption.Visible = lblID.Visible = lblClientCaption.Visible = lblClient.Visible = lblAssistantCaption.Visible = lblAssistant.Visible = lblDateCaption.Visible = lblDate.Visible = lblInvoiceNoCaption.Visible = lblInvoiceNo.Visible = true;
        }

        private void lbxLastInvoices_DoubleClick(object sender, EventArgs e)
        {
            selectedReceipt = ((Receipt)lbxLastInvoices.SelectedItem);
            if (lbxLastInvoices.SelectedIndex != -1) LoadReceipt(selectedReceipt);
        }

        private void btnInvoiceSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Receipt r = shop.GetReceipt(Convert.ToInt32(tbxInvoiceSearch.Text));
                if (r != null)
                {
                    selectedReceipt = r;
                    LoadReceipt(r);
                }
                else DirectMessage.ShowInfo("Invoice not found.");
            }
            catch (FormatException)
            {
                DirectMessage.ShowError("Input is not in correct format.");
            }
        }

        private void btnRefundSelected_Click(object sender, EventArgs e)
        {
            if (DGVItems.SelectedCells.Count == 1)
            {
                if(Convert.ToInt32(DGVItems.CurrentRow.Cells[4].Value) > 0)
                {
                    btnRefundSelected.Enabled = false;
                    Basket basket = new Basket();
                    basket.AddProduct(new Product(Convert.ToInt32(DGVItems.CurrentRow.Cells[0].Value), Convert.ToInt32(DGVItems.CurrentRow.Cells[4].Value), Convert.ToDecimal(DGVItems.CurrentRow.Cells[3].Value)));
                    shop.RefundProduct(new Receipt(selectedReceipt.ID, shop, selectedReceipt.Client, selectedReceipt.Assistant, basket, Convert.ToDecimal(DGVItems.CurrentRow.Cells[3].Value) * Convert.ToInt32(DGVItems.CurrentRow.Cells[4].Value)));
                    UpdateLastInvoices();
                    selectedReceipt = shop.GetReceipt(selectedReceipt.ID);
                    LoadReceipt(selectedReceipt);
                    MessageBox.Show("Refund successfully completed.");
                    btnRefundSelected.Enabled = true;
                }
                else
                {
                    DirectMessage.ShowInfo("Refund quantity must be at least 1.");
                }
            }
            else
            {
                DirectMessage.ShowError("You have to select an item.");
            }
        }
        private void UpdateRefundAmount()
        {
            decimal sum = 0;
            for (int i = 0; i < DGVItems.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(DGVItems.Rows[i].Cells[3].Value) * Convert.ToInt32(DGVItems.Rows[i].Cells[4].Value);
            }
        }

        private void DGVItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //UpdateRefundAmount();
        }

        private void DGVItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                try
                {
                    int value = Convert.ToInt32(e.FormattedValue);
                    if (value >= 0)
                    {
                        if (selectedReceipt.ReceiptItems[e.RowIndex].Quantity - value < 0)
                        {
                            DGVItems.Rows[e.RowIndex].ErrorText = "Refund quantity cannot exceed quantity.";
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        DirectMessage.ShowError("Refund quantity cannot be negative.");
                        e.Cancel = true;
                    }
                }
                catch(FormatException)
                {
                    DirectMessage.ShowError("This is not a quantity number.");
                    e.Cancel = true;
                }
            }
        }

        private void DGVItems_SelectionChanged(object sender, EventArgs e)
        {
            decimal selectedSum;
            if (DGVItems.SelectedCells.Count == 1)
            {
                selectedSum = Convert.ToDecimal(DGVItems.CurrentRow.Cells[3].Value) * Convert.ToInt32(DGVItems.CurrentRow.Cells[4].Value);
                tbxRefundSelectedAmount.Text = selectedSum.ToString("N2");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateLastInvoices();
            if(selectedReceipt != null)
            {
                selectedReceipt = shop.GetReceipt(selectedReceipt.ID);
                LoadReceipt(selectedReceipt);
            }
            DirectMessage.ShowInfo("Successfully updated.");
        }

        private void btnRefundAll_Click(object sender, EventArgs e)
        {
            if (DGVItems.SelectedCells.Count == 1)
            {
                    Basket basket = new Basket();
                for (int i = 0; i < DGVItems.Rows.Count; ++i)
                {
                    if (Convert.ToInt32(DGVItems.Rows[i].Cells[5].Value) > 0)
                    {
                        basket.AddProduct(new Product(Convert.ToInt32(DGVItems.Rows[i].Cells[0].Value), Convert.ToInt32(DGVItems.Rows[i].Cells[5].Value), Convert.ToDecimal(DGVItems.Rows[i].Cells[3].Value)));
                    }
                }
                if(basket.BasketProducts.Count == 0)
                {
                    DirectMessage.ShowInfo("There are no products left for refund.");
                }
                else
                {
                    string messageBoxText = "This will refund all products in their ORIGINAL quantities from the invoice. Do you want to proceed?";
                    string caption = "Important";
                    MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            btnRefundSelected.Enabled = false;
                            shop.RefundProduct(new Receipt(selectedReceipt.ID, shop, selectedReceipt.Client, selectedReceipt.Assistant, basket, Convert.ToDecimal(tbxNetAmount.Text)));
                            UpdateLastInvoices();
                            selectedReceipt = shop.GetReceipt(selectedReceipt.ID);
                            LoadReceipt(selectedReceipt);
                            MessageBox.Show("Refund successfully completed.");
                            btnRefundSelected.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
                }
            else
            {
                DirectMessage.ShowError("You have to select an invoice.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (selectedReceipt != null)
            {
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
                DialogResult result = printDialog.ShowDialog();
                if (result == DialogResult.OK) printDocument.Print();
            }
            else DirectMessage.ShowError("You have to select a receipt first.");
        }
        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                Receipt receipt = shop.GetReceipt(selectedReceipt.ID);
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
