using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2IT
{
    public class Deanery
    {
        public List<Order> Orders
        {
            get;
            private set;
        }

        public Deanery()
        {
            Orders = new List<Order>();
        }

        public string CreateOrder(Order order)
        {
            Orders.Add(order);
            return order.Content;
        }
    }
}
