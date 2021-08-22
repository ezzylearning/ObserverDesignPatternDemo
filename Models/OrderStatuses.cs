using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPatternDemo.Models
{
    public enum OrderStatuses
    {
        PendingPayment = 1,
        OnHold = 2,
        Processing = 3,
        Shipped = 4,
        Cancelled = 5,
        Refunded = 6,
        Failed = 7,
        Completed = 8
    }
}
