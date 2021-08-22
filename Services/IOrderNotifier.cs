using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
    public interface IOrderNotifier
    {
        // Attach an order observer to the subject.
        void Attach(IOrderObserver observer);

        // Detach an order observer from the subject.
        void Detach(IOrderObserver observer);

        // Notify all order observers about an event.
        void Notify(Order order);
    }
}
