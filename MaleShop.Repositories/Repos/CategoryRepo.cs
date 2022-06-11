using MaleShop.Data;
using MaleShop.Domains;
using MaleShop.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Repositories.Repos
{
    public class CategoryRepo : ICategoryInterface
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //Add Category
        public Task<Category> AddCategoryd(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return Task.FromResult(category);
        }

        //Delete Category
        public Task DeleteCategory(Guid categoryId)
        {
            dbContext.Categories.Remove(dbContext.Categories.FirstOrDefault(p => p.Id == categoryId));
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        //Get a Category
        public Task<Category> GetCategory(Guid categoryId) =>
            Task.FromResult(dbContext.Categories.FirstOrDefault(p => p.Id == categoryId));

        //Get all Categories
        public Task<List<Category>> GetCategories() =>
            Task.FromResult(dbContext.Categories.OrderBy(p => p.Name).ToList());

        //Update Category and return 
        public Task<Category> UpdateCategory(Category category)
        {
            dbContext.Categories.Update(category);
            dbContext.SaveChanges();
            return Task.FromResult(category);
        }
    }
}
