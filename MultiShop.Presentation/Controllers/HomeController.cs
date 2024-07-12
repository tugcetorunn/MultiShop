using Microsoft.AspNetCore.Mvc;

namespace MultiShop.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
