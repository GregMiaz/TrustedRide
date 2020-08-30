using RentARide.Domain.Models;
using RentARide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentARide.Infrastructure.Implementations
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
