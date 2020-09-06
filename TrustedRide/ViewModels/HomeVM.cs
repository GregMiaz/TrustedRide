using System.Collections.Generic;
using TrustedRide.Domain.Models;

namespace TrustedRide.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Car> CarsInPromotion { get; set; }
    }
}
