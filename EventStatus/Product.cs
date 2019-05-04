using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventStatus
{
    public class Product
    {
        private string name = "";
        private string description = "";
        public int ID { get; }
        public int Quantity { get; }
        public decimal TotalSoldPrice { get; }
        public string Name
        {
            get
            {
                if (name == "")
                {
                    name = GetProductByID(ID).Name;
                }
                return name;
            }
        }
        public string Description
        {
            get
            {
                if (description == "")
                {
                    description = GetProductByID(ID).Description;
                }
                return description;
            }
        }
        public Product(int id, int count)
        {
            ID = id;
            Quantity = count;
        }
        public Product(int id, int quantity, decimal totalSoldPrice)
        {
            ID = id;
            Quantity = quantity;
            TotalSoldPrice = totalSoldPrice;
        }
        public Product(int id, string name, string description)
        {
            ID = id;
            this.name = name;
            this.description = description;
        }
        public static Product GetProductByID(int id)
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id, name, description FROM ml_product WHERE id = " + id, helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Product(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["description"].ToString());
                }
                return null;
            }
        }
    }
}
