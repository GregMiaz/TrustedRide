using RentARide.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentARide.Infrastructure.Interfaces
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAllBrands();
    }
}
