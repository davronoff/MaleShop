using MaleShop.AdminDashboard.Services;
using MaleShop.AdminDashboard.ViewModels;
using MaleShop.Domains;
using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MaleShop.AdminDashboard.Controllers
{
    public class SellingProductController : Controller
    {
        private readonly ICategoryInterface categoryInterface;
        private readonly IBrandInterface brandInterface;
        private readonly ISellingProductInterface sellingProduct;
        private readonly IImageControllerInterface imageController;

        public SellingProductController(ICategoryInterface categoryInterface,
                              IBrandInterface brandInterface,
                              ISellingProductInterface sellingProduct,
                              IImageControllerInterface imageController)
        {
            this.categoryInterface = categoryInterface;
            this.brandInterface = brandInterface;
            this.sellingProduct = sellingProduct;
            this.imageController = imageController;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            SellingProductIndexViewModel viewModel = new SellingProductIndexViewModel()
            {
                SellingProducts = await sellingProduct.GetSellingProducts(),
                Categories = await categoryInterface.GetCategories(),
                Brands = await brandInterface.GetBrands()
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddSellingProductViewModel viewModel)
        {
            SellingProduct sellingProduct1 = new SellingProduct()
            {
                Id = Guid.NewGuid(),
                Name = viewModel.Name,
                Size = viewModel.Size,
                Color = viewModel.Color,
                Price = viewModel.Price,
                Image = imageController.SaveImage(viewModel.Image),
                CreatedTime = DateTime.Now,
                BrandId = viewModel.BrandId,
                CategoryId = viewModel.CategoryId
            };
            await sellingProduct.AddSellingProduct(sellingProduct1);
            return RedirectToAction("index");
        }
    }
}
