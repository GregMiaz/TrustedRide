using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentARide.Infrastructure.Interfaces;
using RentARide.ViewModels;

namespace RentARide.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly IBrandRepository _brandRepository;

        public CarController(ICarRepository carRepository, IBrandRepository brandRepository)
        {
            _carRepository = carRepository;
            _brandRepository = brandRepository;
        }

        public IActionResult List()
        {
            var model = new CarListVM();
            model.Cars = _carRepository.GetAllCars();
            model.BrandName = "Test Brand";

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            var model = new CarDetailsVM()
            {
                Name = car.Name,
                ShortDescription = car.ShortDescription,
                LongDescription = car.LongDescription,
                Price = car.Price,
                PictureUrl = car.PictureUrl
            };

            return View(model);
        }
    }
}
