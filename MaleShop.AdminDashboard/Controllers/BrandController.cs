using MaleShop.Domains;
using Microsoft.AspNetCore.Mvc;

namespace MaleShop.AdminDashboard.Controllers
{
    public class BrandController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
