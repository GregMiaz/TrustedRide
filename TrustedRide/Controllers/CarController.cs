using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrustedRide.ViewModels;
using TrustedRide.Infrastructure.Interfaces;
using TrustedRide.Domain.Models;

namespace TrustedRide.Controllers
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

        public IActionResult List(string brand) 
        {
            IEnumerable<Car> cars;
            string currentBrand = string.Empty;

            if (string.IsNullOrEmpty(brand))
            {
                cars = _carRepository.GetAllCars().OrderBy(c => c.CarId);
                currentBrand = "All brands";
            }
            else 
            {
                cars = _carRepository.GetAllCars().Where(c => c.Brand.Name == brand).OrderBy(c => c.CarId);
                currentBrand = _brandRepository.GetAllBrands().FirstOrDefault(b => b.Name == brand).Name;
            }

            var model = new CarListVM
            {
                Cars = cars,
                BrandName = currentBrand
            };

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
