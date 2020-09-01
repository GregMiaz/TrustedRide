using System;
using System.Collections.Generic;
using System.Text;
using TrustedRide.Domain.Models;
using TrustedRide.Services.Implementations;

namespace TrustedRide.Services.Interfaces
{
    public interface IDealerCart
    {
        void AddToCart(Car car, int amount);
        public int RemoveFromCart(Car car);
        IEnumerable<DealerCartItem> GetDealerCartItems();
        void ClearCart();
        decimal GetCartTotal();
    }
}
