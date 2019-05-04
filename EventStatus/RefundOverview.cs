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
    public partial class RefundOverview : Form
    {
        Event myEvent;
        private DataTable refundDataTable;
        private DataTable refundsPerShopDataTable;
        private Refund refundStats;
        public RefundOverview(ref Event myEvent)
        {
            InitializeComponent();
            this.myEvent = myEvent;
            CreateRefundTable();
            CreateRefundsPerShopTable();
            UpdateData();
            UpdateRefundDataTable();
            UpdateRefundsPerShopDataTable();
            refundStats = myEvent.GetLastRefund();
            lblLastRefund.Text = refundStats.Date.ToString();
            Shop s = myEvent.GetShopMostRefunds();
            lblMostRefundsShop.Text = s.Name + " (" + s.Bills + ")";
            Visitor v = myEvent.GetVisitorMostRefunds();
            lblMostRefundsVisitor.Text = v.FirstName + " " + v.LastName +" (" + v.RefundCount + ")"; ;
            Assistant a = myEvent.GetAssistantMostRefunds();
            lblMostRefundsAssistant.Text = a.Name + " (" + a.RefundCount + ")"; ;
            Product p = myEvent.GetProductMostRefunds();
            lblMostRefundsProduct.Text = p.Name + " (" + p.Quantity + ")";
            timerUpdateData.Start();
        }
        private void CreateRefundTable()
        {
            refundDataTable = new DataTable();
            refundDataTable.Columns.Add("ID", typeof(int)).ReadOnly = true;
            refundDataTable.Columns.Add("Shop", typeof(string)).ReadOnly = true;
            refundDataTable.Columns.Add("Visitor", typeof(string)).ReadOnly = true;
            refundDataTable.Columns.Add("Assistant", typeof(string)).ReadOnly = true;
            refundDataTable.Columns.Add("Bill ID", typeof(int)).ReadOnly = true;
            refundDataTable.Columns.Add("Amount", typeof(decimal)).ReadOnly = true;
            refundDataTable.Columns.Add("Date", typeof(string)).ReadOnly = true;
            DGVRefunds.DataSource = refundDataTable;
        }
        private void CreateRefundsPerShopTable()
        {
            refundsPerShopDataTable = new DataTable();
            refundsPerShopDataTable.Columns.Add("Shop", typeof(string)).ReadOnly = true;
            refundsPerShopDataTable.Columns.Add("Min", typeof(decimal)).ReadOnly = true;
            refundsPerShopDataTable.Columns.Add("Max", typeof(decimal)).ReadOnly = true;
            refundsPerShopDataTable.Columns.Add("Avg", typeof(decimal)).ReadOnly = true;
            refundsPerShopDataTable.Columns.Add("Count", typeof(int)).ReadOnly = true;
            refundsPerShopDataTable.Columns.Add("Total amount", typeof(decimal)).ReadOnly = true;
            DGVRefundsPerShop.DataSource = refundsPerShopDataTable;
        }
        private void UpdateData()
        {
            Refund r = myEvent.GetRefundStats();
            lblTotalNrOfRefunds.Text = r.Count.ToString();
            lblTotalRefundAmount.Text = r.Amount.ToString();
            lblMinRefundAmount.Text = r.Min.ToString();
            lblMaxRefundAmount.Text = r.Max.ToString();
            lblAvgRefundAmount.Text = r.Avg.ToString();
        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateRefundDataTable()
        {
            refundDataTable.Clear();
            List<Refund> temp = myEvent.GetRefunds();
            foreach (Refund r in temp)
            {
                refundDataTable.Rows.Add(r.ID, new Shop(r.ShopID).Name, new Visitor(r.VisitorID).FirstName + " " + new Visitor(r.VisitorID).LastName, new Assistant(r.AssistantID).Name, r.BillID, r.Amount, r.Date.ToString());
            }
        }
        private void UpdateRefundsPerShopDataTable()
        {
            refundsPerShopDataTable.Clear();
            List<Shop> temp = myEvent.GetRefundStatsPerShop();
            foreach (Shop s in temp)
            {
                refundsPerShopDataTable.Rows.Add(s.Name, s.Min, s.Max, s.Avg, s.Bills, s.TotalSold);
            }
        }

        private void btnRefreshRefunds_Click(object sender, EventArgs e)
        {
            UpdateRefundDataTable();
            DirectMessage.ShowInfo("Update successful");
        }

        private void btnRefreshRefundsPerShop_Click(object sender, EventArgs e)
        {
            UpdateRefundsPerShopDataTable();
            DirectMessage.ShowInfo("Update successful");
        }
    }
}
