using Microsoft.EntityFrameworkCore;
using TrustedRide.Domain.Models;
using TrustedRide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrustedRide.Infrastructure.Implementations
{
    public class CarRepository : ICarRepository
    {
        private readonly TrustedRideDbContext _context;

        public CarRepository(TrustedRideDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllCars()
            => _context.Cars.Include(p => p.Brand);

        public IEnumerable<Car> GetAvailableCars()
            => _context.Cars.Include(p => p.Brand).Where(p => p.IsAvailable == true);

        public IEnumerable<Car> GetCarsInPromotion()
            => _context.Cars.Include(p => p.Brand).Where(p => p.IsInPromotion == true);

        public Car GetCarById(int carId)
            => _context.Cars.FirstOrDefault(p => p.CarId == carId);
    }
}
