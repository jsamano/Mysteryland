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

namespace ShopManage
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            UpdateShops();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                string type = "";
                if (rbtnShop.Checked) type = "shop";
                else type = "loan_stand";
                using (DBHelper helper = new DBHelper())
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO ml_stand (name, type) VALUES (@name, @type);", helper.GetConnection());
                        command.Parameters.AddWithValue("@name", tbxName.Text);
                        command.Parameters.AddWithValue("@type", type);
                        helper.Open();
                        if (command.ExecuteNonQuery() == 1) {
                            DirectMessage.ShowInfo("Shop added successfully.");
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lbShops.SelectedIndex != -1)
            {
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM ml_stand WHERE id = @stand_id", helper.GetConnection());
                    command.Parameters.AddWithValue("@stand_id", lbShops.SelectedValue);
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        DirectMessage.ShowInfo("Shop removed successfully.");
                        UpdateShops();
                    }
                    else DirectMessage.ShowError("Something went wrong.");
                }
            }
            else DirectMessage.ShowError("You have to select a shop.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateShops();
            DirectMessage.ShowInfo("Successfully updated.");
        }
    }
}
