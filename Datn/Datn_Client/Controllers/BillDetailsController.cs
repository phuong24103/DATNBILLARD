using Microsoft.AspNetCore.Mvc;

namespace Datn_Client.Controllers
{
    public class BillDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BillDetails()
        {
            return View();
        }
    }
}