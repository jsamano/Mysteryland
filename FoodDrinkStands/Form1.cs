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

namespace FoodDrinkStands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using(DBHelper helper = new DBHelper())
            {
                try
                {
                    MySqlDataAdapter adapter;
                    DataTable table = new DataTable();
                    helper.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM ml_stand WHERE type = 'shop'", helper.GetConnection());
                    adapter.Fill(table);
                    lbxStandID.DataSource = table;
                    lbxStandID.DisplayMember = "name";
                    lbxStandID.ValueMember = "id";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("You have to connect to VPN.");
                    Environment.Exit(-1);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT name FROM ml_assistant WHERE id = @id AND BINARY password = @password AND stand_id = @stand_id", helper.GetConnection());
                command.Parameters.AddWithValue("@id", tbxAssistentID.Text);
                command.Parameters.AddWithValue("@password", tbxPassword.Text);
                command.Parameters.AddWithValue("@stand_id", lbxStandID.SelectedValue);
                helper.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        this.Hide();
                        MainInterface main = new MainInterface(Convert.ToInt32(lbxStandID.SelectedValue), Convert.ToInt32(tbxAssistentID.Text));
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username, password or stand.");
                    }
                }
            }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
