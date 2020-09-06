using Microsoft.AspNetCore.Mvc;

namespace TrustedRide.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}
