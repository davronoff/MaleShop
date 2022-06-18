using MaleFashion.VIewModels;
using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaleFashion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryInterface categoryInterface;
        private readonly IBrandInterface brandInterface;
        private readonly ISellingProductInterface sellingProduct;

        public HomeController(ICategoryInterface categoryInterface,
                              IBrandInterface brandInterface,
                              ISellingProductInterface sellingProduct)
        {
            this.categoryInterface = categoryInterface;
            this.brandInterface = brandInterface;
            this.sellingProduct = sellingProduct;
        }
        public async Task<IActionResult> Index()
        {
            IndexViewModel viewModel = new()
            {
                SelLingProduucts = await sellingProduct.GetSellingProducts()
            };
            return View(viewModel);
        }
        public IActionResult About()
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
        [HttpGet]
        public async Task<IActionResult> Shop()
        {
            ShopViewModel viewModel = new ShopViewModel()
            {
                SellingProducts = await sellingProduct.GetSellingProducts(),
                Brands = await brandInterface.GetBrands(),
                Categories = await categoryInterface.GetCategories()
            };
            return View(viewModel);
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