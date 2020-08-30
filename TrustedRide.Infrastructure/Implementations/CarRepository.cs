using Microsoft.EntityFrameworkCore;
using RentARide.Domain.Models;
using RentARide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentARide.Infrastructure.Implementations
{
    public class CarRepository : ICarRepository
    {
        private readonly TrustedRideDbContext _context;

        public CarRepository(TrustedRideDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetAllAvailableCars()
            => _context.Cars.Include(p => p.Brand).Where(p => p.IsAvailable == true);

        public IEnumerable<Car> GetAllCars()
            => _context.Cars.Include(p => p.Brand);

        public Car GetCarById(int carId)
            => _context.Cars.FirstOrDefault(p => p.CarId == carId);
    }
}
