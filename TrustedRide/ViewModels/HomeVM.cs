using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustedRide.Domain.Models;

namespace TrustedRide.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Car> CarsInPromotion { get; set; }
    }
}
