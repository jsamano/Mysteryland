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
    public partial class CampingSpotsOverview : Form
    {
        Event myEvent;
        public CampingSpotsOverview(ref Event myEvent)
        {
            InitializeComponent();
            this.myEvent = myEvent;
            UpdateData();
            timerUpdateData.Start();
        }
        private void UpdateData()
        {
            UpdateBookedSpots();
        }
        private void UpdateBookedSpots()
        {
            lblBookedSpots.Text = myEvent.GetBookedCampingSpotsCount().ToString();
            lblFreeSpots.Text = (Convert.ToInt32(lblTotalSpots.Text) - Convert.ToInt32(lblBookedSpots.Text)).ToString();
        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
