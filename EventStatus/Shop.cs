using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventStatus
{
    public class Shop
    {
        public enum Field { name };
        private string name = "";
        public int ID { get; }
        public decimal Min { get; }
        public decimal Max { get; }
        public decimal Avg { get; }
        public int Bills { get; }
        public decimal TotalSold { get; }
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
        public Shop(int id, int count)
        {
            ID = id;
            Bills = count;
        }
        public Shop(int id, decimal min, decimal max, decimal avg, int bills, decimal totalSold)
        {
            ID = id;
            Min = min;
            Max = max;
            Avg = avg;
            Bills = bills;
            TotalSold = totalSold;
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
        public override string ToString()
        {
            return Name + " - Mysteryland";
        }
    }
}
