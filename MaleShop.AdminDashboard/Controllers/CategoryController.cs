using MaleShop.AdminDashboard.ViewModels;
using MaleShop.Domains;
using MaleShop.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MaleShop.AdminDashboard.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryInterface categoryInterface;

        public CategoryController(ICategoryInterface categoryInterface)
        {
            this.categoryInterface = categoryInterface;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ListOfCategory = await categoryInterface.GetCategories();

            if(ListOfCategory is null)
            {
                return View();
            }

            return View(ListOfCategory);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category category)
        {
            Category category1 = new Category()
            {
                Id = Guid.NewGuid(),
                Name = category.Name
            };
            await categoryInterface.AddCategoryd(category1);
            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await categoryInterface.GetCategory(id);
            return View((EditCategoryViewModel)model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryViewModel v)
        {
            await categoryInterface.UpdateCategory((Category)v);
            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            await categoryInterface.DeleteCategory(categoryId);
            return RedirectToAction("index");
        }
    }
}
