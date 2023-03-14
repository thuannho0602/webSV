using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
