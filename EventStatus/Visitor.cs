using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventStatus
{
    public class Visitor
    {
        private int privateID = 0;
        private string username = "";
        private string email = "";
        private string firstname = "";
        private string lastname = "";
        private string title = "";
        private DateTime birthdate;
        private string country = "";
        private string city = "";
        private string street = "";
        private string streetno = "";
        private DateTime checkInTime;
        public enum Field { private_id, username, email, firstname, lastname, title, birthdate, country, city, street, streetno, balance, present, checkout, check_in };
        public int ID { get; }
        public int PrivateID
        {
            get
            {
                string result = GetInfo(Field.private_id);
                if (!string.IsNullOrEmpty(result))
                {
                    privateID = Convert.ToInt32(result);
                }
                return privateID;
            }
        }
        public string Username
        {
            get
            {
                if (username == "") username = GetInfo(Field.username); return username;
            }
        }
        public string Email
        {
            get
            {
                if (email == "") email = GetInfo(Field.email); return email;
            }
        }
        public string FirstName
        {
            get
            {
                if (firstname == "") firstname = GetInfo(Field.firstname); return firstname;
            }
        }
        public string LastName
        {
            get
            {
                if (lastname == "") lastname = GetInfo(Field.lastname); return lastname;
            }
        }
        public string Title
        {
            get
            {
                string result = GetInfo(Field.title);
                if (result == "") return "Not specified";
                else title = result;
                return title;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                birthdate = Convert.ToDateTime(GetInfo(Field.birthdate)); return birthdate;
            }
        }
        public string Country
        {
            get
            {
                string result = GetInfo(Field.country);
                if (result == "") return "Not specified";
                else country = result;
                return country;
            }
        }
        public string City
        {
            get
            {
                string result = GetInfo(Field.city);
                if (result == "") return "Not specified";
                else city = result;
                return city;
            }
        }
        public string Street
        {
            get
            {
                string result = GetInfo(Field.street);
                if (result == "") return "Not specified";
                else street = result;
                return street;
            }
        }
        public string StreetNo
        {
            get
            {
                string result = GetInfo(Field.streetno);
                if (result == "") return "Not specified";
                else streetno = result;
                return streetno;
            }
        }
        public decimal Balance
        {
            get
            {
                return Convert.ToDecimal(GetInfo(Field.balance));
            }
        }
        public int IsPresent
        {
            get
            {
                string result = GetInfo(Field.present);
                if (!string.IsNullOrEmpty(result))
                {
                    return Convert.ToInt32(result);
                }
                return -1;
            }
        }
        public int CheckedOut
        {
            get
            {
                string result = GetInfo(Field.checkout);
                if (!string.IsNullOrEmpty(result))
                {
                    return Convert.ToInt32(result);
                }
                return -1;
            }
        }
        public DateTime CheckInTime
        {
            get
            {
                string result = GetInfo(Field.check_in);
                if (!string.IsNullOrEmpty(result))
                {
                    checkInTime = Convert.ToDateTime(result);
                }
                return checkInTime;
            }
        }
        public int RefundCount { get; }

        public Visitor(int id)
        {
            ID = id;
        }
        public Visitor(int id, int refundCount)
        {
            ID = id;
            RefundCount = refundCount;
        }
        public static Visitor FindVisitorByID(int id)
        {
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id FROM ml_visitor WHERE id = " + id, helper.GetConnection());
                //command.Parameters.AddWithValue("@field", validField);
                helper.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Visitor(Convert.ToInt32(reader["id"]));
                }
                return null;
            }
        }
        public static List<Visitor> FindVisitorByName(string name)
        {
            List<Visitor> temp = new List<Visitor>();
            using (DBHelper helper = new DBHelper())
            {
                MySqlCommand command = new MySqlCommand("SELECT id FROM ml_visitor WHERE firstname LIKE '%" + name + "%' OR lastname LIKE '%" + name + "%';", helper.GetConnection());
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

        public string GetInfo(Field field)
        {
            string result = "";
            string expression = "";
            if (Enum.IsDefined(typeof(Field), field))
            {
                    expression = field.ToString();
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
            string holder = "ID: " + ID + " - ";
            if (Title != "")
            {
                holder += title + " ";
            }
            holder += FirstName + " " + LastName + " - Birthdate: " + Birthdate.ToShortDateString();
            if (Country != "Not specified")
            {
                holder += " - " + Country;
            }
            return holder;
        }
    }
}
