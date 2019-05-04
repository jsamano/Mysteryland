using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FoodDrinkStands
{
    public class Client
    {
        private string name = "";
        public enum Field { name, balance };
        public int ID { get; }
        public string Name {
            get
            {
                if(name == "") name = GetInfo(Field.name); return name;
            }
        }
        public decimal Balance
        {
            get
            {
                return Convert.ToDecimal(GetInfo(Field.balance));
            }
        }

        public Client(int id)
        {
            ID = id;
        }

        public static Client FindUser(string code)
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id FROM ml_visitor WHERE RFID_code = '" + code + "';", helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Client(Convert.ToInt32(reader["id"]));
                }
                return null;
            }
        }

        public string GetInfo(Field field)
        {
            string result = "";
            string expression = "";
            if(Enum.IsDefined(typeof(Field), field))
            {
                if(field == Field.name)
                {
                    expression = "CONCAT(firstname, ' ', lastname) AS name";
                }
                else if (field == Field.balance)
                {
                    expression = "balance";
                }
                using (DBHelper helper = new DBHelper())
                    {
                        MySqlCommand command = new MySqlCommand("SELECT " + expression + " FROM ml_visitor WHERE id = " + ID, helper.GetConnection());
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
            return Name;
        }
    }
}
