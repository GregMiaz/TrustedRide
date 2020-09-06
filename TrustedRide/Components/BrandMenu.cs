using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TrustedRide.Infrastructure.Interfaces;

namespace TrustedRide.Components
{
    public class BrandMenu : ViewComponent
    {
        private readonly IBrandRepository _brandRepository;

        public BrandMenu(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public IViewComponentResult Invoke() 
        {
            var brands = _brandRepository.GetAllBrands().OrderBy(b => b.Name);
            return View(brands);
        }
    }
}
