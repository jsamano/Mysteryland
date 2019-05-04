using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventStatus
{
    public partial class VisitorSearch : Form
    {
        public VisitorSearch()
        {
            InitializeComponent();
        }

        private void btnVisitorSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            string searchString = tbxVisitorSearch.Text;
            if (searchString != "")
            {
                try
                {
                    if (rbtnVisitorNo.Checked)
                    {
                        int id = Convert.ToInt32(searchString);
                        Visitor v = Visitor.FindVisitorByID(id);
                        if (v != null)
                        {
                            lbResults.Items.Add(v);
                        }
                        else DirectMessage.ShowInfo("No results found.");
                    }
                    else
                    {
                        string name = searchString;
                        List<Visitor> visitors = Visitor.FindVisitorByName(name);
                        if(visitors.Count != 0)
                        {
                            foreach (Visitor visitor in visitors)
                            {
                                lbResults.Items.Add(visitor);
                            }
                        }
                        else DirectMessage.ShowInfo("No results found.");
                    }
                }
                catch (FormatException)
                {
                    DirectMessage.ShowError("Search query is not in correct format.");
                }
            }
            else DirectMessage.ShowWarning("You have to input a search query");
        }

        public static void ShowVisitorInfo(Visitor v)
        {
            string holder = "ID: " + v.ID + "\n" +
            "Private ID: ";
            if (v.PrivateID == 0) holder += "Unknown"; else holder += v.PrivateID;
            holder += "\nUsername: " + v.Username + "\n" +
            "Email: " + v.Email + "\n" +
            "First name: " + v.FirstName + "\n" +
            "Last name: " + v.LastName + "\n" +
            "Title: " + v.Title + "\n" +
            "Birthdate: " + v.Birthdate + "\n" +
            "Country: " + v.Country + "\n" +
            "City: " + v.City + "\n" +
            "Street: " + v.Street + "\n" +
            "Street No: " + v.StreetNo + "\n" +
            "Balance: " + v.Balance + "\n" +
            "Present on event: ";
            if (v.IsPresent == -1) holder += "Not present on the event";
            else if (v.IsPresent == 0) holder += "Checked-out from the event";
            else holder += "Present on the event";
            if (v.CheckInTime != DateTime.MinValue) { holder += "\nChecked-in time: " + v.CheckInTime; }
            holder += "\nCamping status: ";
            if (v.CheckedOut == -1) holder += "No camping spot reserved";
            else if (v.CheckedOut == 0) holder += "Checked-out from the camping spot";
            else holder += "Checked-in in a camping spot";
            MessageBox.Show(holder);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex != -1) ShowVisitorInfo((Visitor)lbResults.SelectedItem);
        }
    }
}
