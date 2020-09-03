using System;
using System.Collections.Generic;
using System.Text;
using TrustedRide.Domain.Models;

namespace TrustedRide.Infrastructure.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
