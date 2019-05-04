using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDrinkStands
{
    public class Receipt
    {
        public List<Product> ReceiptItems { get; }
        public int ID { get; }
        public Shop Shop { get; }
        public Client Client { get; }
        public Assistant Assistant { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }

        public Receipt(int id, Shop shop, Client client, Assistant assistant, Basket basket, decimal amount)
        {
            ID = id;
            Shop = shop;
            Client = client;
            Assistant = assistant;
            Date = DateTime.Now;
            ReceiptItems = new List<Product>();
            foreach(Product p in basket.BasketProducts)
            {
                ReceiptItems.Add(p);
            }
            Amount = amount;
        }
        public Receipt(int id, Shop shop, Client client, Assistant assistant, Basket basket, DateTime date, decimal amount)
        {
            ID = id;
            Shop = shop;
            Client = client;
            Assistant = assistant;
            Date = date;
            ReceiptItems = new List<Product>();
            foreach (Product p in basket.BasketProducts)
            {
                ReceiptItems.Add(p);
            }
            Amount = amount;
        }
        public override string ToString()
        {
            return "ID: " + ID + " - Date: " + Date + " - Client: " + Client.Name + " - Amount: " + Amount + " - Asssistant: " + Assistant.Name;
        }
    }
}
