using Microsoft.AspNetCore.Mvc;

namespace MaleShop.AdminDashboard.Controllers
{
    public class SellingProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
