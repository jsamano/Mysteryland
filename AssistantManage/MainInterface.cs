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

namespace AssistantManage
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            UpdateAssistants();
            UpdateStands();
        }
        private void UpdateAssistants()
        {
            lbAssistants.DataSource = null;
            lbAssistants.Items.Clear();
            using (DBHelper helper = new DBHelper())
            {
                try
                {
                    MySqlDataAdapter adapter;
                    DataTable table = new DataTable();
                    helper.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM ml_assistant ORDER BY id DESC", helper.GetConnection());
                    adapter.Fill(table);
                    lbAssistants.DataSource = table;
                    lbAssistants.DisplayMember = "name";
                    lbAssistants.ValueMember = "id";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("You have to connect to VPN.");
                    Environment.Exit(-1);
                }
            }
        }
        private void UpdateStands()
        {
            lbStands.DataSource = null;
            lbStands.Items.Clear();
            using (DBHelper helper = new DBHelper())
            {
                try
                {
                    MySqlDataAdapter adapter;
                    DataTable table = new DataTable();
                    helper.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM ml_stand ORDER BY id DESC", helper.GetConnection());
                    adapter.Fill(table);
                    lbStands.DataSource = table;
                    lbStands.DisplayMember = "name";
                    lbStands.ValueMember = "id";
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
            if (tbxAssistantName.Text != "")
            {
                if(lbStands.SelectedIndex != -1)
                {
                    using (DBHelper helper = new DBHelper())
                    {
                        try
                        {
                            MySqlCommand command = new MySqlCommand("INSERT INTO ml_assistant (name, password, stand_id) VALUES (@name, @password, @stand_id);", helper.GetConnection());
                            command.Parameters.AddWithValue("@name", tbxAssistantName.Text);
                            command.Parameters.AddWithValue("@password", tbxPassword.Text);
                            command.Parameters.AddWithValue("@stand_id", lbStands.SelectedValue);
                            helper.Open();
                            if (command.ExecuteNonQuery() == 1)
                            {
                                DirectMessage.ShowInfo("Assistant added successfully.");
                                UpdateAssistants();
                            }
                            else DirectMessage.ShowError("Something went wrong.");
                        }
                        catch (MySqlException)
                        {
                            DirectMessage.ShowError("There was problem executing the operation.");
                        }
                    }
                }
                else DirectMessage.ShowError("You have to select a shop.");
            }
            else DirectMessage.ShowError("You have to fill in a name.");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbAssistants.SelectedIndex != -1)
            {
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM ml_assistant WHERE id = @id", helper.GetConnection());
                    command.Parameters.AddWithValue("@id", lbAssistants.SelectedValue);
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        DirectMessage.ShowInfo("Assisatant removed successfully.");
                        UpdateAssistants();
                    }
                    else DirectMessage.ShowError("Something went wrong.");
                }
            }
            else DirectMessage.ShowError("You have to select an assistant.");
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (lbAssistants.SelectedIndex != -1 && lbStands.SelectedIndex != -1)
            {
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("UPDATE ml_assistant SET stand_id = @stand_id WHERE id = @id", helper.GetConnection());
                    command.Parameters.AddWithValue("@stand_id", lbStands.SelectedValue);
                    command.Parameters.AddWithValue("@id", lbAssistants.SelectedValue);
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        DirectMessage.ShowInfo("Assistant stand updated successfully.");
                    }
                    else DirectMessage.ShowError("Something went wrong.");
                }
            }
            else DirectMessage.ShowError("You have to select an assistant and a stand.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateAssistants();
            UpdateStands();
            DirectMessage.ShowInfo("Successfully updated.");
        }
    }
}
