using _10.Models;
using System.Collections.Generic;

namespace _10.Data_Access
{
    public class OrderRippo
    {
        public static List<Order> Orders = new List<Order>
        {
            new Order{Id=1,CustomerId=2,Productid= new List<int>{1,2}},
            new Order{Id=2,CustomerId=2,Productid= new List<int>{3,4}},
            new Order{Id=3,CustomerId=2,Productid= new List<int>{5}}
        };
        public List<Order> GetList()
        {
            return Orders;
        }
        public void Add(Order order)
        {
            Orders.Add(order);
        }
    }
}
