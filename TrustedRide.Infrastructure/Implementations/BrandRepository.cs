using RentARide.Domain.Models;
using RentARide.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentARide.Infrastructure.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private readonly RentARideDbContext _context;

        public BrandRepository(RentARideDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetAllBrands()
            => _context.Brands;
    }
}
