using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDrinkStands
{
    public class Basket
    {
        private List<Product> basketProducts;
        public List<Product> BasketProducts
        {
            get { return basketProducts; }
        }
        public Basket()
        {
            basketProducts = new List<Product>();
        }
        public Product FindProduct(int id)
        {
            foreach(Product p in basketProducts)
            {
                if (p.ID == id) return p;
            }
            return null;
        }
        public bool AddProduct(Product p)
        {
            if (FindProduct(p.ID) == null)
            {
                if (p.Quantity > 0)
                {
                    basketProducts.Add(p);
                    return true;
                }
            }
            return false;
        }
        public bool IncrementingAddProduct(Product p)
        {
            if (p.Quantity > 0)
            {
                if (FindProduct(p.ID) == null) basketProducts.Add(p);
                else FindProduct(p.ID).Quantity++;
            }
            return false;
        }
        public bool RemoveProduct(int id)
        {
            Product p = FindProduct(id);
            if (p != null)
            {
                basketProducts.Remove(p);
                return true;
            }
            return false;
        }
        public bool UpdateQuantity(int id, int quantity)
        {
            Product p = FindProduct(id);
            if (p != null)
            {
                p.Quantity = quantity;
                return true;
            }
            return false;
        }
    }
}
