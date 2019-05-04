using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ATMLogConvert
{
    class Converter
    {
        private string receiverAccount;
        private string dateStartPeriod;
        private string dateEndPeriod;
        private int amountOfDeposits;
        private DateTime date;
        private List<Deposit> deposits;
        public Converter(string receiverAccount, string dateStartPeriod, string dateEndPeriod, int amountOfDeposits, List<Deposit> deposits)
        {
            this.receiverAccount = receiverAccount;
            this.dateStartPeriod = dateStartPeriod;
            this.dateEndPeriod = dateEndPeriod;
            this.amountOfDeposits = amountOfDeposits;
            this.deposits = deposits;
            date = DateTime.Now;
        }
        public bool InsertData()
        {
            using (DBHelper helper = new DBHelper())
            {
                int nrOfRowsInserted = 0;
                MySqlCommand insertPeriodStats = new MySqlCommand("INSERT INTO ml_atm_stats (period_start, period_end, deposits, bankaccount, process_date) VALUES ('" + dateStartPeriod + "', '" + dateEndPeriod + "', " + deposits.Count + ", '" + receiverAccount + "', '" + date.Date.ToString("yyyy-MM-dd HH:mm:ss") + "');", helper.GetConnection());
                helper.Open();
                //r.Date.ToString("yyyy-MM-dd HH:mm:ss")
                if (insertPeriodStats.ExecuteNonQuery() == 1)
                {
                    nrOfRowsInserted++;
                }
                MySqlCommand insertPeriodDeposits = null;
                foreach (Deposit d in deposits)
                {
                    insertPeriodDeposits = new MySqlCommand("INSERT INTO ml_atm_log (date, receiver_account, visitor_id, amount) VALUES ('" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + receiverAccount + "', " + d.VisitorID + ", " + d.Amount + ");", helper.GetConnection());
                    if (insertPeriodDeposits.ExecuteNonQuery() == 1)
                    {
                        nrOfRowsInserted++;
                    }
                }
                //command.Parameters.AddWithValue("@field", validField);
                if (nrOfRowsInserted == deposits.Count + 1) return true;
                return false;
            }
        }
    }
}
