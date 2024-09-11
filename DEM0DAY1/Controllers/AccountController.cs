using Microsoft.AspNetCore.Mvc;

namespace DEM0DAY1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
