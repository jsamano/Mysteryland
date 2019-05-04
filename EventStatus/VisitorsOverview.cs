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
    public partial class VisitorsOverview : Form
    {
        Event myEvent;
        public VisitorsOverview(ref Event myEvent)
        {
            InitializeComponent();
            this.myEvent = myEvent;
            UpdateData();
            timerUpdateData.Start();
        }
        private void UpdateData()
        {
            UpdatePresentVisitors();
            UpdateTotalVisitors();
        }
        private void UpdatePresentVisitors()
        {
            lblPresentVisitors.Text = myEvent.GetPresentVisitorsCount().ToString();
        }
        private void UpdateTotalVisitors()
        {
            lblTotalVisitors.Text = myEvent.GetTotalVisitorsCount().ToString();
        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
