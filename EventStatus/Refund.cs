using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStatus
{
    public class Refund
    {
        public int ID { get; }
        public int ShopID { get; }
        public int VisitorID { get; }
        public int AssistantID { get; }
        public int BillID { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }

        public decimal Min { get; }
        public decimal Max { get; }
        public decimal Avg { get; }
        public decimal Count { get; }

        public Refund (int id, int shopID, int visitorID, int assistantID, int billID, decimal amount, DateTime date)
        {
            ID = id;
            ShopID = shopID;
            VisitorID = visitorID;
            AssistantID = assistantID;
            BillID = billID;
            Amount = amount;
            Date = date;
        }
        public Refund(decimal min, decimal max, decimal avg, int count, decimal amount)
        {
            Min = min;
            Max = max;
            Avg = avg;
            Count = count;
            Amount = amount;
        }
    }
}
