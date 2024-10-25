using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Aggregation
{
    public class ShoppingCart
    {
        public ShoppingCart() { }

        public int Id { get; set; }
        public string Username { get; set; }

        public DateTime LastUpdated { get; set; }

        public double Total { get; set; }

        public string CouponApplied { get; set; }

        public List<Item> Items { get; set; }

        public void AddToCart(Item i)
        { 
            Items.Add(i); 
        }
    }
}
