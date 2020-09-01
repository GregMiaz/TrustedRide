using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrustedRide.Domain.Models;
using TrustedRide.Infrastructure;
using TrustedRide.Services.Interfaces;

namespace TrustedRide.Services.Implementations
{
    public class DealerCart : IDealerCart
    {
        private readonly TrustedRideDbContext _context;

        public string DealerCartId { get; set; }
        public List<DealerCartItem> DealerCartItems { get; set; }


        public DealerCart(TrustedRideDbContext context)
        {
            _context = context;
        }

        public static DealerCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<TrustedRideDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new DealerCart(context) { DealerCartId = cartId };

        }

        public void AddToCart(Car car, int quantity)
        {
            var cartItem = _context
                .DealerCartItems
                .SingleOrDefault(s => s.Car.CarId == car.CarId && s.DealerCartId == DealerCartId);

            if (cartItem == null)
            {
                cartItem = new DealerCartItem
                {
                    DealerCartId = DealerCartId,
                    Car = car,
                    Quantity = 1
                };
                _context.DealerCartItems.Add(cartItem);
            }
            else 
            {
                cartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems = _context.DealerCartItems.Where(c => c.DealerCartId == DealerCartId);

            _context.DealerCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public IEnumerable<DealerCartItem> GetDealerCartItems()
            => DealerCartItems ??= 
            _context.DealerCartItems
            .Where(c => c.DealerCartId == DealerCartId)
            .Include(s => s.Car)
            .ToList();

        public int RemoveFromCart(Car car)
        {
            var cartItem = _context
                .DealerCartItems
                .SingleOrDefault(s => s.Car.CarId == car.CarId && s.DealerCartId == DealerCartId);

            int localQuantity = 0;

            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                    localQuantity = cartItem.Quantity;
                }
                else
                {
                    _context.DealerCartItems.Remove(cartItem);
                }
            }

            _context.SaveChanges();

            return localQuantity;
        }

        public decimal GetCartTotal()
        {
            var total = _context.DealerCartItems
                .Where(c => c.DealerCartId == DealerCartId)
                .Select(c => c.Car.Price * c.Quantity)
                .Sum();

            return total;
        }
    }
}
