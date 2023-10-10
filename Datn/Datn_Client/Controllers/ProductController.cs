using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProductController()
        {
            return View();
        }

        public IActionResult TestProduct()
        {
            return View();
        }
    }
}