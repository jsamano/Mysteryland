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
    public partial class VisitorBalanceOverview : Form
    {
        Event myEvent;
        public VisitorBalanceOverview(ref Event myEvent)
        {
            InitializeComponent();
            this.myEvent = myEvent;
            UpdateData();
            timerUpdateData.Start();
        }
        private void UpdateData()
        {
            UpdateTotalSpent();
            UpdateTotalBalance();
        }
        private void UpdateTotalSpent()
        {
            lblTotalSpent.Text = myEvent.GetTotalSpent().ToString();
        }
        private void UpdateTotalBalance()
        {
            lblTotalBalance.Text = myEvent.GetTotalVisitorBalance().ToString();
        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
