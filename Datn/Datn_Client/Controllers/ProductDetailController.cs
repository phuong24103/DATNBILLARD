using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}