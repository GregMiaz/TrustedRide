using System.Collections.Generic;

namespace TrustedRide.Domain.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}
