using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
    public class OrderService : IOrderService 
    { 
        public List<IOrderObserver> Observers = new List<IOrderObserver>();

        public void UpdateOrder(Order order)
        {
            Notify(order);
        }

        public void Attach(IOrderObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify(Order order)
        {
            foreach (var observer in Observers)
            {
                observer.Update(order);
            }
        }
    }
}
