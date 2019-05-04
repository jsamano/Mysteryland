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

namespace ProductManage
{
    public partial class MainInterface : Form
    {
        private RFID rfid;
        public MainInterface()
        {
            InitializeComponent();
            UpdateProducts();
            UpdateShops();
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Error += new ErrorEventHandler(rfid_Error);
            rfid.Tag += new RFIDTagEventHandler(rfid_Tag);
            rfid.TagLost += new RFIDTagLostEventHandler(rfid_TagLost);
            rfid.Open();
        }
        private void UpdateProducts()
        {
            lbProducts.DataSource = null;
            lbProducts.Items.Clear();
            using (DBHelper helper = new DBHelper())
            {
                try
                {
                    MySqlDataAdapter adapter;
                    DataTable table = new DataTable();
                    helper.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM ml_product ORDER BY id DESC", helper.GetConnection());
                    adapter.Fill(table);
                    lbProducts.DataSource = table;
                    lbProducts.DisplayMember = "name";
                    lbProducts.ValueMember = "id";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("You have to connect to VPN.");
                    Environment.Exit(-1);
                }
            }
        }
        private void UpdateShops()
        {
            lbShops.DataSource = null;
            lbShops.Items.Clear();
            using (DBHelper helper = new DBHelper())
            {
                try
                {
                    MySqlDataAdapter adapter;
                    DataTable table = new DataTable();
                    helper.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM ml_stand ORDER BY id DESC", helper.GetConnection());
                    adapter.Fill(table);
                    lbShops.DataSource = table;
                    lbShops.DisplayMember = "name";
                    lbShops.ValueMember = "id";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("You have to connect to VPN.");
                    Environment.Exit(-1);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                    using (DBHelper helper = new DBHelper())
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand("INSERT INTO ml_product (name, description) VALUES (@name, @description);", helper.GetConnection());
                            command.Parameters.AddWithValue("@name", tbxName.Text);
                            command.Parameters.AddWithValue("@type", rtbxDescription.Text);
                            helper.Open();
                            if (command.ExecuteNonQuery() == 1)
                            {
                                DirectMessage.ShowInfo("Product added successfully.");
                                UpdateShops();
                            }
                            else DirectMessage.ShowError("Something went wrong.");
                        }
                        catch (MySqlException)
                        {
                            DirectMessage.ShowError("There was problem executing the operation.");
                        }
                    }
            }
            else DirectMessage.ShowError("You have to fill in a name.");
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1)
            {
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM ml_product WHERE id = @id", helper.GetConnection());
                    command.Parameters.AddWithValue("@id", lbProducts.SelectedValue);
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        DirectMessage.ShowInfo("Product removed successfully.");
                        UpdateShops();
                    }
                    else DirectMessage.ShowError("Something went wrong.");
                }
            }
            else DirectMessage.ShowError("You have to select a product.");
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
        }
        void rfid_TagLost(object sender, RFIDTagLostEventArgs e)
        {
            lblTag.Text = "-";
        }

        private void cbAntenna_CheckedChanged(object sender, EventArgs e)
        {
            rfid.AntennaEnabled = cbAntenna.Checked;
        }

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            rfid.Attach -= new AttachEventHandler(rfid_Attach);
            rfid.Detach -= new DetachEventHandler(rfid_Detach);
            rfid.Error -= new ErrorEventHandler(rfid_Error);
            rfid.Tag -= new RFIDTagEventHandler(rfid_Tag);
            rfid.TagLost -= new RFIDTagLostEventHandler(rfid_TagLost);

            rfid.Close();
            rfid = null;
        }

        private void btnAddProductToShop_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1 && lbShops.SelectedIndex != -1)
            {
                if (lblTag.Text != "-")
                {
                    try
                    {
                        int quantity = Convert.ToInt32(tbxQuantity.Text);
                        try
                        {
                            decimal price = Convert.ToDecimal(tbxPrice.Text);
                            using (DBHelper helper = new DBHelper())
                            {
                                try
                                {
                                    MySqlCommand command = new MySqlCommand("INSERT INTO ml_shop_product (shop_id, product_id, RFID_code, quantity, price) VALUES (@shop_id, @product_id, @rfid_code, @quantity, @price);", helper.GetConnection());
                                    command.Parameters.AddWithValue("@shop_id", lbShops.SelectedValue);
                                    command.Parameters.AddWithValue("@product_id", lbProducts.SelectedValue);
                                    command.Parameters.AddWithValue("@rfid_code", lblTag.Text);
                                    command.Parameters.AddWithValue("@quantity", quantity);
                                    command.Parameters.AddWithValue("@price", price);
                                    helper.Open();
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        DirectMessage.ShowInfo("Product added successfully.");
                                    }
                                    else DirectMessage.ShowError("Something went wrong.");
                                }
                                catch (MySqlException)
                                {
                                    DirectMessage.ShowError("There was problem executing the operation.");
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            DirectMessage.ShowError("Invalid price format.");
                        }
                    }
                    catch (FormatException)
                    {
                        DirectMessage.ShowError("Invalid quantity format.");
                    }
                }
                else DirectMessage.ShowError("You have to read an RFID code.");
            }
            else DirectMessage.ShowError("You have to select a product and a shop to which to add it.");
        }

        private void btnRemoveProductFromShop_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1 && lbShops.SelectedIndex != -1)
            {
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM ml_shop_product WHERE shop_id = @shop_id AND product_id = @product_id", helper.GetConnection());
                    command.Parameters.AddWithValue("@shop_id", lbShops.SelectedValue);
                    command.Parameters.AddWithValue("@product_id", lbProducts.SelectedValue);
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        DirectMessage.ShowInfo("Product removed successfully.");
                    }
                    else DirectMessage.ShowError("Something went wrong.");
                }
            }
            else DirectMessage.ShowError("You have to select a product and a shop from which to remove it.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateProducts();
            UpdateShops();
            DirectMessage.ShowInfo("Successfully updated.");
        }
    }
}
