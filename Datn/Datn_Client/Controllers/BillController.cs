using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bill()
        {
            return View();
        }
    }
}