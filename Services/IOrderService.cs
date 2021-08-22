using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPatternDemo.Models;

namespace ObserverDesignPatternDemo.Services
{
   public interface IOrderService : IOrderNotifier
   {
       void UpdateOrder(Order order);
   }
}
