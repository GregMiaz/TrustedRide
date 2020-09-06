using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TrustedRide.Infrastructure.Interfaces;
using TrustedRide.ViewModels;

namespace TrustedRide.Controllers
{
    public class DealerCartController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IDealerCart _dealerCart;

        public DealerCartController(ICarRepository carRepository, IDealerCart dealerCart)
        {
            _carRepository = carRepository;
            _dealerCart = dealerCart;
        }

        public IActionResult Index()
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

        public IActionResult AddCarToDealerCart(int id) 
        {
            var chosenCar = _carRepository
                .GetAllCars()
                .FirstOrDefault(c => c.CarId == id);

            if (chosenCar != null)
            {
                _dealerCart.AddToCart(chosenCar, 1);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCarFromDealerCart(int id) 
        {
            var carToRemove = _carRepository
                .GetAllCars()
                .FirstOrDefault(c => c.CarId == id);

            if (carToRemove != null)
            {
                _dealerCart.RemoveFromCart(carToRemove);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
