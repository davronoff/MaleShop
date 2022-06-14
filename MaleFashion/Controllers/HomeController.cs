using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaleFashion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISellingProductInterface sellingProduct;

        public HomeController(ISellingProductInterface sellingProduct)
        {
            this.sellingProduct = sellingProduct;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Main()
        {
            return View();
        }
        public async Task<IActionResult> Shop()
        {
            var item = await sellingProduct.GetSellingProducts();
            return View(item);
        }
        public IActionResult Shopdetails()
        {
            return View();
        }
        public IActionResult Shoppingcart()
        {
            return View();
        }
    }
}