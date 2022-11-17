using Microsoft.AspNetCore.Mvc;

namespace AppMVCModelo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}