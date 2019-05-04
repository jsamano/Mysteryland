using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventStatus
{
    public class Event
    {
        public enum Field { private_id, username, email, firstname, lastname, title, birthdate, country, city, street, streetno, balance, present, checkout };
        public List<Visitor> GetAllVisitors()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Visitor> temp = new List<Visitor>();
                //MySqlCommand command = new MySqlCommand("SELECT id, private_id, RFID_code, username, email, firstname, lastname, title, birthdate, country, city, street, streetno, balance, present, checkout FROM ml_visitor", helper.GetConnection());
                MySqlCommand command = new MySqlCommand("SELECT id FROM ml_visitor ORDER BY id DESC", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Visitor(Convert.ToInt32(reader["id"])));
                }
                return temp;
            }
        }
        public List<Visitor> GetLatestVisitors(int n)
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Visitor> temp = new List<Visitor>();
                MySqlCommand command = new MySqlCommand("SELECT id FROM ml_visitor WHERE present = '1' ORDER BY check_in DESC LIMIT " + n, helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Visitor(Convert.ToInt32(reader["id"])));
                }
                return temp;
            }
        }
        public int GetPresentVisitorsCount()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM ml_visitor WHERE present = '1'", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public int GetTotalVisitorsCount()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM ml_visitor", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public decimal GetTotalVisitorBalance()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT SUM(balance) FROM ml_visitor", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }
        public decimal GetTotalSpent()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command;
                decimal totalSpentInFoodDrinksStands = 0;
                decimal totalSpentInLoanStands = 0;
                command = new MySqlCommand("SELECT SUM(amount) FROM ml_shop_bill", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                Object result = command.ExecuteScalar();
                if(result != DBNull.Value) totalSpentInFoodDrinksStands = Convert.ToDecimal(result);
                command = new MySqlCommand("SELECT SUM(amount) FROM ml_loan_bill", helper.GetConnection());
                result = command.ExecuteScalar();
                if (result != DBNull.Value) totalSpentInLoanStands = Convert.ToDecimal(result);
                return totalSpentInFoodDrinksStands + totalSpentInLoanStands;
            }
        }
        public List<Product> GetTotalSoldPerProduct()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Product> temp = new List<Product>();
                MySqlCommand command = new MySqlCommand("SELECT product_id, SUM(quantity) AS 'Quantity', SUM(price * quantity) AS 'Price' FROM ml_shop_bill_purchase GROUP BY product_id;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Product(Convert.ToInt32(reader["product_id"]), Convert.ToInt32(reader["Quantity"]), Convert.ToDecimal(reader["Price"])));
                }
                return temp;
            }
        }
        public List<Product> GetTotalLoanedPerProduct()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Product> temp = new List<Product>();
                MySqlCommand command = new MySqlCommand("SELECT product_id, SUM(quantity) AS 'Quantity', SUM(price * quantity) AS 'Price' FROM ml_loan_bill_product GROUP BY product_id;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Product(Convert.ToInt32(reader["product_id"]), Convert.ToInt32(reader["Quantity"]), Convert.ToDecimal(reader["Price"])));
                }
                return temp;
            }
        }
        public List<Shop> GetTotalMoneyPerFoodDrinksStand()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Shop> temp = new List<Shop>();
                MySqlCommand command = new MySqlCommand("SELECT shop_id, MIN(amount) AS 'Min', MAX(amount) AS 'Max', AVG(amount) AS 'Avg', COUNT(shop_id) AS 'Bills', SUM(amount) AS 'Amount' FROM ml_shop_bill GROUP BY shop_id;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Shop(Convert.ToInt32(reader["shop_id"]), Convert.ToDecimal(reader["Min"]), Convert.ToDecimal(reader["Max"]), Convert.ToDecimal(reader["Avg"]), Convert.ToInt32(reader["Bills"]) , Convert.ToDecimal(reader["Amount"])));
                }
                return temp;
            }
        }
        public List<Shop> GetTotalMoneyPerLoanStand()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Shop> temp = new List<Shop>();
                MySqlCommand command = new MySqlCommand("SELECT stand_id, MIN(amount) AS 'Min', MAX(amount) AS 'Max', AVG(amount) AS 'Avg', COUNT(stand_id) AS 'Bills', SUM(amount) AS 'Amount' FROM ml_loan_bill GROUP BY stand_id;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Shop(Convert.ToInt32(reader["stand_id"]), Convert.ToDecimal(reader["Min"]), Convert.ToDecimal(reader["Max"]), Convert.ToDecimal(reader["Avg"]), Convert.ToInt32(reader["Bills"]), Convert.ToDecimal(reader["Amount"])));
                }
                return temp;
            }
        }
        public List<Refund> GetRefunds()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Refund> temp = new List<Refund>();
                MySqlCommand command = new MySqlCommand("SELECT id, shop_id, visitor_id, assistant_id, bill_id, amount, date FROM ml_shop_refund", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Refund(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["shop_id"]), Convert.ToInt32(reader["visitor_id"]), Convert.ToInt32(reader["assistant_id"]), Convert.ToInt32(reader["bill_id"]), Convert.ToDecimal(reader["amount"]), Convert.ToDateTime(reader["date"])));
                }
                return temp;
            }
        }
        public Refund GetLastRefund()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id, shop_id, visitor_id, assistant_id, bill_id, amount, date FROM ml_shop_refund ORDER BY date DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Refund(Convert.ToInt32(reader["id"]), Convert.ToInt32(reader["shop_id"]), Convert.ToInt32(reader["visitor_id"]), Convert.ToInt32(reader["assistant_id"]), Convert.ToInt32(reader["bill_id"]), Convert.ToDecimal(reader["amount"]), Convert.ToDateTime(reader["date"]));
                }
                return null;
            }
        }
        public Refund GetRefundStats()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT MIN(amount) AS 'Min', MAX(amount) AS 'Max', AVG(amount) AS 'Avg', COUNT(id) AS 'Bills', SUM(amount) AS 'Amount' FROM ml_shop_refund", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Refund(Convert.ToDecimal(reader["Min"]), Convert.ToDecimal(reader["Max"]), Convert.ToDecimal(reader["Avg"]), Convert.ToInt32(reader["Bills"]), Convert.ToDecimal(reader["Amount"]));
                }
                return null;
            }
        }
        public List<Shop> GetRefundStatsPerShop()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Shop> temp = new List<Shop>();
                MySqlCommand command = new MySqlCommand("SELECT shop_id, MIN(amount) AS 'Min', MAX(amount) AS 'Max', AVG(amount) AS 'Avg', COUNT(shop_id) AS 'Bills', SUM(amount) AS 'Amount' FROM ml_shop_refund GROUP BY shop_id;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp.Add(new Shop(Convert.ToInt32(reader["shop_id"]), Convert.ToDecimal(reader["Min"]), Convert.ToDecimal(reader["Max"]), Convert.ToDecimal(reader["Avg"]), Convert.ToInt32(reader["Bills"]), Convert.ToDecimal(reader["Amount"])));
                }
                return temp;
            }
        }
        public Visitor GetVisitorMostRefunds()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT visitor_id, COUNT(visitor_id) AS 'count' FROM ml_shop_refund GROUP BY visitor_id DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Visitor(Convert.ToInt32(reader["visitor_id"]), Convert.ToInt32(reader["count"]));
                }
                return null;
            }
        }
        public Assistant GetAssistantMostRefunds()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT assistant_id, COUNT(assistant_id) AS 'count' FROM ml_shop_refund GROUP BY assistant_id DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Assistant(Convert.ToInt32(reader["assistant_id"]), Convert.ToInt32(reader["count"]));
                }
                return null;
            }
        }
        public Shop GetShopMostRefunds()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT shop_id, COUNT(shop_id) AS 'count' FROM ml_shop_refund GROUP BY shop_id DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Shop(Convert.ToInt32(reader["shop_id"]), Convert.ToInt32(reader["count"]));
                }
                return null;
            }
        }
        public Product GetProductMostRefunds()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT product_id, SUM(quantity) AS 'count' FROM ml_shop_refund_item GROUP BY product_id DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Product(Convert.ToInt32(reader["product_id"]), Convert.ToInt32(reader["count"]));
                }
                return null;
            }
        }
        public decimal GetBiggestRefundAmount()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT MAX(amount) FROM ml_shop_refund", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                return Convert.ToDecimal(command.ExecuteScalar());
            }
        }
        public int GetBookedCampingSpotsCount()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM ml_camping_reservation;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}
