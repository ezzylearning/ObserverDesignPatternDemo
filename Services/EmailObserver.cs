using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
    public class EmailObserver : IOrderObserver
    {
        public void Update(Order order)
        {
            Console.WriteLine("Order No '{0}' status is updated to '{1}'. An email sent to customer.", 
                order.OrderNumber, order.OrderStatus.ToString());
        }
    }
}
