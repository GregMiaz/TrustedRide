using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrustedRide.ViewModels
{
    public class CarDetailsVM
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
    }
}
