using RentARide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentARide.Infrastructure.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetAllAvailableCars();
        Car GetCarById(int carId);
    }
}
