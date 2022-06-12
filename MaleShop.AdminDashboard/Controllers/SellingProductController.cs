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
        private readonly IWebHostEnvironment webHost;

        public SellingProductController(ICategoryInterface categoryInterface,
                              IBrandInterface brandInterface,
                              ISellingProductInterface sellingProduct,
                              IImageControllerInterface imageController,
                              IWebHostEnvironment webHost)
        {
            this.categoryInterface = categoryInterface;
            this.brandInterface = brandInterface;
            this.sellingProduct = sellingProduct;
            this.imageController = imageController;
            this.webHost = webHost;
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
        public IActionResult Add()
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
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var item = await sellingProduct.GetSellingProduct(id);
            string img = Path.Combine(webHost.WebRootPath, "photos", item.Image);
            FileInfo info = new FileInfo(img);
            if(info != null)
            {
                System.IO.File.Delete(img);
            }
            await sellingProduct.DeleteSellingProduct(id);
            return RedirectToAction("index");
        }
    }
}
