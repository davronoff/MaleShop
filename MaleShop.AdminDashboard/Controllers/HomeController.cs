using MaleShop.AdminDashboard.ViewModels;
using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaleShop.AdminDashboard.Controllers
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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IndexHomeViewModel viewModel = new IndexHomeViewModel()
            {
                Brands = await brandInterface.GetBrands(),
                Categories = await categoryInterface.GetCategories(),
                SellingProducts = await sellingProduct.GetSellingProducts()
            };
            return View(viewModel);
        }
    }
}