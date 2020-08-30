using TrustedRide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustedRide.ViewModels
{
    public class CarListVM
    {
        public IEnumerable<Car> Cars { get; set; }
        public string BrandName { get; set; }
    }
}
