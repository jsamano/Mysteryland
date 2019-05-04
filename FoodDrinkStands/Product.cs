using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FoodDrinkStands
{
    public class Product
    {
        public enum Field { id, rfid_code, name, description, quantity, price };
        private string name = "";
        private string description = "";
        private string rfid_code = "";
        public int ID { get; }
        public string Name
        {
            get
            {
                if (name == "")
                {
                    name = GetInfo(Field.name);
                }
                return name;
            }
        }
        public string RFID_Code
        {
            get
            {
                if (rfid_code == "")
                {
                    rfid_code = GetInfo(Field.rfid_code);
                }
                return rfid_code;
            }
        }
        public string Description
        {
            get
            {
                if (description == "")
                {
                    description = GetInfo(Field.description);
                }
                return description;
            }
        }
        public int Quantity { get; set; }
        public decimal Price { get; }
        public Product(int id, int quantity, decimal price)
        {
            ID = id;
            Quantity = quantity;
            Price = price;
        }
        public Product(int id, string rfid_code, int quantity, decimal price)
        {
            ID = id;
            this.rfid_code = rfid_code;
            Quantity = quantity;
            Price = price;
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
                else if (field == Field.description)
                {
                    expression = "description";
                }
                using (DBHelper helper = new DBHelper())
                {
                    MySqlCommand command = new MySqlCommand("SELECT " + expression + " FROM ml_product WHERE id = " + ID, helper.GetConnection());
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
        public override string ToString()
        {
            return "Code: " + ID + " - " + Name + " - " + Description + " - " + Price + " - Quantity available: " + Quantity;
        }
    }
}
