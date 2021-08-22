using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
    public interface IOrderObserver
    {
        void Update(Order order);
    }
}
