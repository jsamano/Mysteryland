using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FoodDrinkStands
{
    public class Shop
    {
        public enum Field { name };
        private string name = "";
        public List<Product> Products { get { return LoadProducts(); } }
        public List<Receipt> Receipts { get { return LoadReceipts(); } }
        public int ID { get; }
        public string Name
        {
            get
            {
                if (name == "") name = GetInfo(Field.name); return name;
            }
        }
        public Shop(int id)
        {
            ID = id;
        }
        public string GetInfo(Field field)
        {
            string result = "";
            string expression = "";
            if (Enum.IsDefined(typeof(Field), field))
            {
                if (field == Field.name)
                {
                    expression = "name";
                }
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("SELECT " + expression + " FROM ml_stand WHERE id = " + ID, helper.GetConnection());
                    //command.Parameters.AddWithValue("@field", validField);
                    helper.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader[field.ToString()].ToString();
                    }
                    helper.Close();
                }
            }
            return result;
        }
        public List<Product> LoadProducts()
        {
                using (DBHelper helper = new DBHelper())
                {
                List<Product> temp = new List<Product>();
                    MySqlCommand command = new MySqlCommand("SELECT product_id, RFID_code, quantity, price FROM ml_shop_product WHERE shop_id = " + ID, helper.GetConnection());
                    //command.Parameters.AddWithValue("@field", validField);
                    helper.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    temp.Add(new Product(Convert.ToInt32(reader["product_id"]), reader["RFID_code"].ToString(), Convert.ToInt32(reader["quantity"]), Convert.ToDecimal(reader["price"])));
                    }
                return temp;
                }
        }
        public List<Receipt> LoadReceipts()
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Receipt> temp = new List<Receipt>();
                MySqlCommand command = new MySqlCommand("SELECT id, visitor_id, assistant_id, date, amount FROM ml_shop_bill WHERE shop_id = " + ID + " ORDER BY id DESC;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader ReceiptReader = command.ExecuteReader();
                while (ReceiptReader.Read())
                {
                    int receiptID = Convert.ToInt32(ReceiptReader["id"]);
                    int visitorID = Convert.ToInt32(ReceiptReader["visitor_id"]);
                    int assistantID = Convert.ToInt32(ReceiptReader["assistant_id"]);
                    DateTime date = Convert.ToDateTime(ReceiptReader["date"]);
                    decimal amount = Convert.ToDecimal(ReceiptReader["amount"]);
                    Basket basket = new Basket();
                    temp.Add(new Receipt(receiptID, new Shop(ID), new Client(visitorID), new Assistant(assistantID), basket, date, amount));
                }
                ReceiptReader.Close();
                foreach (Receipt r in temp)
                {
                    command = new MySqlCommand("SELECT product_id, quantity, price FROM ml_shop_bill_purchase WHERE bill_id = " + r.ID + ";", helper.GetConnection());
                    ReceiptReader = command.ExecuteReader();
                    while (ReceiptReader.Read())
                    {
                        r.ReceiptItems.Add(new Product(Convert.ToInt32(ReceiptReader["product_id"]), Convert.ToInt32(ReceiptReader["quantity"]), Convert.ToDecimal(ReceiptReader["price"])));
                    }
                    ReceiptReader.Close();
                }
                return temp;
            }
        }
        //public Receipt GetLastReceipt()
        //{
        //    return receipts[receipts.Count - 1];
        //}
        //public List<Receipt> GetLastReceipts(int i)
        //{
        //    List<Receipt> temp = receipts.TakeLast(i);
        //}
        public Receipt GetLastReceipt()
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id, visitor_id, assistant_id, date, amount FROM ml_shop_bill WHERE shop_id = " + ID + " ORDER BY id DESC LIMIT 1;", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader ReceiptItemsReader;
                MySqlDataReader ReceiptReader = command.ExecuteReader();
                if (ReceiptReader.Read())
                {
                    int receiptID = Convert.ToInt32(ReceiptReader["id"]);
                    int visitorID = Convert.ToInt32(ReceiptReader["visitor_id"]);
                    int assistantID = Convert.ToInt32(ReceiptReader["assistant_id"]);
                    DateTime date = Convert.ToDateTime(ReceiptReader["date"]);
                    decimal amount = Convert.ToDecimal(ReceiptReader["amount"]);
                    ReceiptReader.Close();
                    command = new MySqlCommand("SELECT product_id, quantity, price FROM ml_shop_bill_purchase WHERE bill_id = " + receiptID, helper.GetConnection());
                    ReceiptItemsReader = command.ExecuteReader();
                    Basket basket = new Basket();
                    while (ReceiptItemsReader.Read())
                    {
                        basket.AddProduct(new Product(Convert.ToInt32(ReceiptItemsReader["product_id"]), Convert.ToInt32(ReceiptItemsReader["quantity"]), Convert.ToDecimal(ReceiptItemsReader["price"])));
                    }
                    return new Receipt(receiptID, new Shop(ID), new Client(visitorID), new Assistant(assistantID), basket, date, amount);
                }
                return null;
            }
        }
        public Receipt GetReceipt(int id)
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT visitor_id, assistant_id, date, amount FROM ml_shop_bill WHERE id = " + id + " AND shop_id = " + ID + ";", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader ReceiptItemsReader;
                MySqlDataReader ReceiptReader = command.ExecuteReader();
                if (ReceiptReader.Read())
                {
                    int visitorID = Convert.ToInt32(ReceiptReader["visitor_id"]);
                    int assistantID = Convert.ToInt32(ReceiptReader["assistant_id"]);
                    DateTime date = Convert.ToDateTime(ReceiptReader["date"]);
                    decimal amount = Convert.ToDecimal(ReceiptReader["amount"]);
                    ReceiptReader.Close();
                    command = new MySqlCommand("SELECT product_id, quantity, price FROM ml_shop_bill_purchase WHERE bill_id = " + id, helper.GetConnection());
                    ReceiptItemsReader = command.ExecuteReader();
                    Basket basket = new Basket();
                    while (ReceiptItemsReader.Read())
                    {
                        basket.AddProduct(new Product(Convert.ToInt32(ReceiptItemsReader["product_id"]), Convert.ToInt32(ReceiptItemsReader["quantity"]), Convert.ToDecimal(ReceiptItemsReader["price"])));
                    }
                    return new Receipt(id, new Shop(ID), new Client(visitorID), new Assistant(assistantID), basket, date, amount);
                }
                return null;
            }
        }
        public List<Receipt> GetLastReceipts(int i)
        {
            using (DBHelper helper = new DBHelper())
            {
                List<Receipt> tempInvoices = new List<Receipt>();
                MySqlCommand command = new MySqlCommand("SELECT id, visitor_id, assistant_id, date, amount FROM ml_shop_bill WHERE shop_id = " + ID + " ORDER BY id DESC LIMIT " + i + ";", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader ReceiptReader = command.ExecuteReader();
                while (ReceiptReader.Read())
                {
                    int receiptID = Convert.ToInt32(ReceiptReader["id"]);
                    int visitorID = Convert.ToInt32(ReceiptReader["visitor_id"]);
                    int assistantID = Convert.ToInt32(ReceiptReader["assistant_id"]);
                    DateTime date = Convert.ToDateTime(ReceiptReader["date"]);
                    decimal amount = Convert.ToDecimal(ReceiptReader["amount"]);
                    Basket basket = new Basket();
                    tempInvoices.Add(new Receipt(receiptID, new Shop(ID), new Client(visitorID), new Assistant(assistantID), basket, date, amount));
                }
                ReceiptReader.Close();
                foreach(Receipt r in tempInvoices)
                {
                    command = new MySqlCommand("SELECT product_id, quantity, price FROM ml_shop_bill_purchase WHERE bill_id = " + r.ID + ";", helper.GetConnection());
                    ReceiptReader = command.ExecuteReader();
                    while (ReceiptReader.Read())
                    {
                        r.ReceiptItems.Add(new Product(Convert.ToInt32(ReceiptReader["product_id"]), Convert.ToInt32(ReceiptReader["quantity"]), Convert.ToDecimal(ReceiptReader["price"])));
                    }
                    ReceiptReader.Close();
                }
                return tempInvoices;
                }
        }
        public bool FinalizeReceipt(Receipt r)
        {
            using (DBHelper helper = new DBHelper())
            {
                if (r.Client.Balance - r.Amount >= 0)
                {
                    int nrOfRowsInserted = 0;
                    MySqlCommand command = new MySqlCommand("INSERT INTO ml_shop_bill (shop_id, visitor_id, assistant_id, date, amount) VALUES (" + ID + ", " + r.Client.ID + ", " + r.Assistant.ID + ", '" + r.Date.ToString("yyyy-MM-dd HH:mm:ss") + "' , " + r.Amount + ");", helper.GetConnection());
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        nrOfRowsInserted++;
                    }
                    command = new MySqlCommand("UPDATE ml_visitor SET balance = balance - " + r.Amount + " WHERE id = " + r.Client.ID + ";", helper.GetConnection());
                    if (command.ExecuteNonQuery() == 1)
                    {
                        nrOfRowsInserted++;
                    }
                    foreach (Product p in r.ReceiptItems)
                    {
                        command = new MySqlCommand("INSERT INTO ml_shop_bill_purchase (bill_id, product_id, quantity, price) VALUES (" + r.ID + ", " + p.ID + ", " + p.Quantity + ", " + p.Price + ");", helper.GetConnection());
                        if (command.ExecuteNonQuery() == 1)
                        {
                            nrOfRowsInserted++;
                        }
                        command = new MySqlCommand("UPDATE ml_shop_product SET quantity = quantity - " + p.Quantity + " WHERE shop_id = " + ID + " AND product_id = " + p.ID + ";", helper.GetConnection());
                        if (command.ExecuteNonQuery() == 1)
                        {
                            nrOfRowsInserted++;
                        }
                        FindProductByCode(p.ID).Quantity -= p.Quantity;
                    }
                    //command.Parameters.AddWithValue("@field", validField);
                    if (nrOfRowsInserted == r.ReceiptItems.Count * 2 + 2) return true;
                    return false;
                }
                else throw new InsufficientBalanceException();
            }
        }
        public bool RefundProduct(Receipt r)
        {
            using (DBHelper helper = new DBHelper())
            {
                int nrOfRowsInserted = 0;
                    MySqlCommand command = new MySqlCommand("INSERT INTO ml_shop_refund (shop_id, visitor_id, assistant_id, bill_id, amount, date) VALUES (" + ID + ", " + r.Client.ID + ", " + r.Assistant.ID + ", " + r.ID + ", " + r.Amount + ", '" + r.Date.ToString("yyyy-MM-dd HH:mm:ss") + "');", helper.GetConnection());
                    helper.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        nrOfRowsInserted++;
                        long id = command.LastInsertedId;
                        command = new MySqlCommand("UPDATE ml_visitor SET balance = balance + " + r.Amount + " WHERE id = " + r.Client.ID + ";", helper.GetConnection());
                        if (command.ExecuteNonQuery() == 1)
                        {
                            nrOfRowsInserted++;
                            foreach (Product p in r.ReceiptItems)
                            {
                                command = new MySqlCommand("INSERT INTO ml_shop_refund_item (refund_id, product_id, quantity, price) VALUES (" + id + ", " + p.ID + ", " + p.Quantity + ", " + p.Price + ");", helper.GetConnection());
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    nrOfRowsInserted++;
                                command = new MySqlCommand("UPDATE ml_shop_bill_purchase SET quantity = quantity - " + p.Quantity + " WHERE bill_id = " + r.ID + " AND product_id = " + p.ID + ";", helper.GetConnection());
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    nrOfRowsInserted++;
                                    command = new MySqlCommand("UPDATE ml_shop_product SET quantity = quantity + " + p.Quantity + " WHERE shop_id = " + ID + " AND product_id = " + p.ID + ";", helper.GetConnection());
                                    if (command.ExecuteNonQuery() == 1)
                                    {
                                        nrOfRowsInserted++;
                                        if (nrOfRowsInserted == r.ReceiptItems.Count * 3 + 2) return true;
                                    }
                                }
                                }
                            }
                        }
                    }
                    //command.Parameters.AddWithValue("@field", validField);
                    return false;
            }
        }
        public Product FindProductByCode(int id)
        {
            foreach (Product p in Products)
            {
                if (p.ID == id) return p;
            }
            return null;
        }
        public Product FindProductByRFIDCode(string code)
        {
            foreach (Product p in Products)
            {
                if (p.RFID_Code == code) return p;
            }
            return null;
        }
        public List<Product> FindProductByName(string searchQuery)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in Products)
            {
                if (p.Name.CaseInsensitiveContains(searchQuery)) temp.Add(p);
            }
            return temp;
        }
        public List<Product> FindProductByDescription(string searchQuery)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in Products)
            {
                if (p.Description.CaseInsensitiveContains(searchQuery)) temp.Add(p);
            }
            return temp;
        }
        public List<Product> FindProduct(string searchQuery)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in Products)
            {
                if (p.ID.ToString().Contains(searchQuery) || p.Name.CaseInsensitiveContains(searchQuery) || p.Description.CaseInsensitiveContains(searchQuery)) temp.Add(p);
            }
            return temp;
        }
        public Product FindReceiptProduct(int receiptID, int productID)
        {
            Receipt r = GetReceipt(receiptID);
            foreach (Product p in r.ReceiptItems)
            {
                if (p.ID == productID) return p;
            }
            return null;
        }
        public override string ToString()
        {
            return Name + " - Mysteryland";
        }
    }
}
