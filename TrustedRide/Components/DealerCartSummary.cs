using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustedRide.Infrastructure.Interfaces;
using TrustedRide.ViewModels;

namespace TrustedRide.Components
{
    public class DealerCartSummary : ViewComponent
    {
        private readonly IDealerCart _dealerCart;

        public DealerCartSummary(IDealerCart dealerCart)
        {
            _dealerCart = dealerCart;
        }

        public IViewComponentResult Invoke() 
        {
            var items = _dealerCart.GetDealerCartItems();
            _dealerCart.DealerCartItems = items;

            var model = new DealerCartVM
            {
                DealerCart = _dealerCart,
                CartTotal = _dealerCart.GetCartTotal()
            };

            return View(model);
        }
    }
}
