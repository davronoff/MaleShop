using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaleShop.AdminDashboard.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}