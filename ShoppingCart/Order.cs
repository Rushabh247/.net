using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShoppingCart
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> LineItems { get; set; }

        public Order(int id)
        {
            Id = id;
            Date = DateTime.Now;
            LineItems = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            LineItems.Add(item);
        }

        public double CalculateOrderPrice()
        {
            double total = 0;
            foreach (var item in LineItems)
            {
                total += item.CalculateLineItemCost();
            }
            return total;
        }
    }
}
