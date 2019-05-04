using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventStatus
{
    public class Assistant
    {
        public enum Field { name };
        private string name = "";
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
        public int RefundCount { get; }
        public Assistant(int id)
        {
            ID = id;
        }
        public Assistant(int id, int refundCount)
        {
            ID = id;
            RefundCount = refundCount;
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
                    MySqlCommand command = new MySqlCommand("SELECT " + expression + " FROM ml_assistant WHERE id = " + ID, helper.GetConnection());
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
    }
}
