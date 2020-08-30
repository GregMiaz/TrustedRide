using System;
using System.Collections.Generic;
using System.Text;
using TrustedRide.Domain.Models;

namespace TrustedRide.Domain.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime ProductionYear { get; set; }
        public int Speed { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string ThumbnailPictureUrl { get; set; }
        public bool IsInPromotion { get; set; }
        public bool IsAvailable { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
