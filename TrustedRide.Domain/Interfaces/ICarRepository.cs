using TrustedRide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrustedRide.Domain.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        IEnumerable<Car> GetAvailableCars();
        IEnumerable<Car> GetCarsInPromotion();
        Car GetCarById(int carId);
    }
}
