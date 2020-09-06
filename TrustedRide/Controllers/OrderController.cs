using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TrustedRide.Domain.Models;
using TrustedRide.Infrastructure.Interfaces;

namespace TrustedRide.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IDealerCart _dealerCart;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IDealerCart dealerCart, IOrderRepository orderRepository)
        {
            _dealerCart = dealerCart;
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order) 
        {
            var items = _dealerCart.GetDealerCartItems();
            _dealerCart.DealerCartItems = items;

            int itemsInCartCounter = _dealerCart.DealerCartItems.Count();

            if (itemsInCartCounter == 0)
            {
                ModelState.AddModelError("", "Your order is empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _dealerCart.ClearCart();
                return RedirectToAction(nameof(OrderFullfilled));
            }

            return View(order);
        }

        public IActionResult OrderFullfilled() 
        {
            ViewBag.Message = "Thank you for your order and enjoy the ride!";
            return View();
        }
    }
}
