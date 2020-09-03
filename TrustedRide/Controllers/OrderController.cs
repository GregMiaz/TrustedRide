using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrustedRide.Infrastructure.Interfaces;

namespace TrustedRide.Controllers
{
    public class OrderController : Controller
    {
        private readonly IDealerCart _dealerCart;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IDealerCart dealerCart, IOrderRepository orderRepository)
        {
            _dealerCart = dealerCart;
            _orderRepository = orderRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
