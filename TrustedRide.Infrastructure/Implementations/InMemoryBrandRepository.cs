using RentARide.Domain.Models;
using RentARide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentARide.Infrastructure.Implementations
{
    public class InMemoryBrandRepository : IBrandRepository
    {
        public IEnumerable<Brand> GetAllBrands()
            => new List<Brand>
            {
                new Brand { BrandId = 1, Name = "Bugatti", Description = "Integrity, compliance and diversity" },
                new Brand { BrandId = 2, Name = "Ferrari", Description = "Italian excellence the rest of the world can only dream of" },
                new Brand { BrandId = 2, Name = "Aston Martin", Description = "Iconic Luxury British Sports Cars" },
            };
    }
}
