using MaleShop.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Repositories.Interface
{
    public interface ICategoryInterface
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(Guid categoryId);
        Task<Category> AddCategoryd(Category category);
        Task<Category> UpdateCategory(Category category);
        Task DeleteCategory(Guid categoryId);
    }
}
