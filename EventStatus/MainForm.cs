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
    public partial class MainForm : Form
    {
        Event myEvent;
        private DataTable shopsDataTable;
        private DataTable productsDataTable;
        VisitorSearch visitorSearchForm;
        public MainForm()
        {
            InitializeComponent();
            myEvent = new Event();
            CreateShopTable();
            CreateProductTable();
            UpdateData();
            UpdateShopsDataTable();
            UpdateProductsDataTable();
            timerUpdateData.Start();
        }
        private void CreateShopTable()
        {
            shopsDataTable = new DataTable();
            shopsDataTable.Columns.Add("ID", typeof(int)).ReadOnly = true;
            shopsDataTable.Columns.Add("Name", typeof(string)).ReadOnly = true;
            shopsDataTable.Columns.Add("Min of orders", typeof(decimal)).ReadOnly = true;
            shopsDataTable.Columns.Add("Max of orders", typeof(decimal)).ReadOnly = true;
            shopsDataTable.Columns.Add("Avg of orders", typeof(decimal)).ReadOnly = true;
            shopsDataTable.Columns.Add("No of bills", typeof(int)).ReadOnly = true;
            shopsDataTable.Columns.Add("Total sell/loan amount", typeof(decimal)).ReadOnly = true;
            DGVShops.DataSource = shopsDataTable;
        }
        private void CreateProductTable()
        {
            productsDataTable = new DataTable();
            productsDataTable.Columns.Add("ID", typeof(int)).ReadOnly = true;
            productsDataTable.Columns.Add("Name", typeof(string)).ReadOnly = true;
            productsDataTable.Columns.Add("Description", typeof(string)).ReadOnly = true;
            productsDataTable.Columns.Add("Total price sold", typeof(decimal)).ReadOnly = true;
            productsDataTable.Columns.Add("Total quantity sold", typeof(int)).ReadOnly = true;
            DGVProducts.DataSource = productsDataTable;
        }
        private void UpdateLatestVisitors()
        {
            lbVisitors.Items.Clear();
            foreach (Visitor r in myEvent.GetLatestVisitors(10))
            {
                lbVisitors.Items.Add(r);
            }
        }
        private void UpdatePresentVisitors()
        {
            lblPresentVisitors.Text = myEvent.GetPresentVisitorsCount().ToString();
        }
        private void UpdateBookedSpots()
        {
            lblBookedSpots.Text = myEvent.GetBookedCampingSpotsCount().ToString();
        }
        private void UpdateRefunds()
        {
            lblRefunds.Text = myEvent.GetRefundStats().Count.ToString();
        }
        private void UpdateTotalVisitorBalance()
        {
            lblTotalBalance.Text = myEvent.GetTotalVisitorBalance().ToString();
        }
        private void UpdateShopsDataTable()
        {
            shopsDataTable.Clear();
            List<Shop> temp = myEvent.GetTotalMoneyPerFoodDrinksStand();
            foreach (Shop s in temp)
            {
                shopsDataTable.Rows.Add(s.ID, s.Name, s.Min, s.Max, s.Avg, s.Bills, s.TotalSold);
            }
            temp = myEvent.GetTotalMoneyPerLoanStand();
            foreach (Shop s in temp)
            {
                shopsDataTable.Rows.Add(s.ID, s.Name, s.Min, s.Max, s.Avg, s.Bills, s.TotalSold);
            }
        }
        private void UpdateProductsDataTable()
        {
            productsDataTable.Clear();
            List<Product> temp = myEvent.GetTotalSoldPerProduct();
            foreach (Product p in temp)
            {
                productsDataTable.Rows.Add(p.ID, p.Name, p.Description, p.TotalSoldPrice, p.Quantity);
            }
            temp = myEvent.GetTotalLoanedPerProduct();
            foreach (Product p in temp)
            {
                productsDataTable.Rows.Add(p.ID, p.Name, p.Description, p.TotalSoldPrice, p.Quantity);
            }
        }
        private void UpdateData()
        {
            UpdatePresentVisitors();
            UpdateBookedSpots();
            UpdateTotalVisitorBalance();
            UpdateLatestVisitors();
            UpdateRefunds();
        }
        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnRefreshTotalMoney_Click(object sender, EventArgs e)
        {
            UpdateShopsDataTable();
            DirectMessage.ShowInfo("Update successful");
        }

        private void btnRefreshSoldAmount_Click(object sender, EventArgs e)
        {
            UpdateProductsDataTable();
            DirectMessage.ShowInfo("Update successful");
        }

        private void lbVisitors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbVisitors.SelectedIndex != -1) VisitorSearch.ShowVisitorInfo((Visitor)lbVisitors.SelectedItem);
        }

        private void btnShowVisitorInfo_Click(object sender, EventArgs e)
        {
            if (lbVisitors.SelectedIndex != -1) VisitorSearch.ShowVisitorInfo((Visitor)lbVisitors.SelectedItem);
        }

        private void btnVisitorSearch_Click(object sender, EventArgs e)
        {
            visitorSearchForm = new VisitorSearch();
            visitorSearchForm.Show();
        }

        private void btnMoreAboutVisitors_Click(object sender, EventArgs e)
        {
            VisitorsOverview visitorsOverviewForm = new VisitorsOverview(ref myEvent);
            visitorsOverviewForm.Show();
        }

        private void btnMoreAboutCampingSpots_Click(object sender, EventArgs e)
        {
            CampingSpotsOverview campingSpotsOverviewForm = new CampingSpotsOverview(ref myEvent);
            campingSpotsOverviewForm.Show();
        }

        private void btnMoreAboutVisitorBalance_Click(object sender, EventArgs e)
        {
            VisitorBalanceOverview visitorBalanceOverviewForm = new VisitorBalanceOverview(ref myEvent);
            visitorBalanceOverviewForm.Show();
        }

        private void btnMoreAboutRefunds_Click(object sender, EventArgs e)
        {
            RefundOverview refundOverviewForm = new RefundOverview(ref myEvent);
            refundOverviewForm.Show();
        }
    }
}
