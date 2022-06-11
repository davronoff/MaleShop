using MaleShop.AdminDashboard.ViewModels;
using MaleShop.Domains;
using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MaleShop.AdminDashboard.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandInterface brandInterface;

        public BrandController(IBrandInterface brandInterface)
        {
            this.brandInterface = brandInterface;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ListOfBrand = await brandInterface.GetBrands();
            return View(ListOfBrand);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Brand m)
        {
            Brand brand = new Brand()
            {
                Id = Guid.NewGuid(),
                Name = m.Name
            };
            await brandInterface.AddBrand(brand);
            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await brandInterface.GetBrand(id);
            return View((EditBrandViewModel)model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditBrandViewModel v)
        {
            await brandInterface.UpdateBrand((Brand)v);
            return RedirectToAction("index");
        }
    }
}
