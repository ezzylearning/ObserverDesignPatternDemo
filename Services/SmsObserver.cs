using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
    public class SmsObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine("Order No '{0}' status is updated to '{1}'. SMS message sent to customer.",
                order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}
