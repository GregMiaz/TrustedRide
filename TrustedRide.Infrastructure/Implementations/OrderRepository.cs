using System;
using System.Collections.Generic;
using System.Text;
using TrustedRide.Domain.Models;
using TrustedRide.Infrastructure.Interfaces;

namespace TrustedRide.Infrastructure.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TrustedRideDbContext _context;
        private readonly IDealerCart _dealerCart;

        public OrderRepository(TrustedRideDbContext context, IDealerCart dealerCart)
        {
            _context = context;
            _dealerCart = dealerCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.UtcNow;
            _context.Orders.Add(order);

            var cartItems = _dealerCart.DealerCartItems;

            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Quantity = item.Quantity,
                    CarId = item.Car.CarId,
                    OrderId = order.OrderId,
                    Price = item.Car.Price
                };
                _context.OrderDetails.Add(orderDetail);
            }
            _context.SaveChanges();
        }
    }
}
