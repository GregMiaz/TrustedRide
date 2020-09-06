using Microsoft.AspNetCore.Mvc;
using TrustedRide.Infrastructure.Interfaces;
using TrustedRide.ViewModels;

namespace TrustedRide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;

        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            var model = new HomeVM
            {
                CarsInPromotion = _carRepository.GetCarsInPromotion()
            };

            return View(model);
        }
    }
}
