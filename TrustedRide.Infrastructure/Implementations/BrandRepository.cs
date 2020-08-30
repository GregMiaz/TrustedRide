using TrustedRide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using TrustedRide.Domain.Models;

namespace TrustedRide.Infrastructure.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private readonly TrustedRideDbContext _context;

        public BrandRepository(TrustedRideDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetAllBrands()
            => _context.Brands;
    }
}
