using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLogConvert
{
    class Deposit
    {
        public int VisitorID { get; }
        public decimal Amount { get; }
        public Deposit(int visitorID, decimal amount)
        {
            VisitorID = visitorID;
            Amount = amount;
        }
    }
}
