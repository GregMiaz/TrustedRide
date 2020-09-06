using System.Collections.Generic;
using TrustedRide.Domain.Models;

namespace TrustedRide.ViewModels
{
    public class CarListVM
    {
        public IEnumerable<Car> Cars { get; set; }
        public string BrandName { get; set; }
    }
}
