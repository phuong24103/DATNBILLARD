using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}