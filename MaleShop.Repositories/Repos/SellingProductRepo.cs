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
    public class SellingProductRepo : ISellingProductInterface
    {
        private readonly ApplicationDbContext dbContext;

        public SellingProductRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<SellingProduct> AddSellingProduct(SellingProduct sellingProduct)
        {
            dbContext.SellingProducts.Add(sellingProduct);
            dbContext.SaveChanges();
            return Task.FromResult(sellingProduct);
        }

        public Task DeleteSellingProduct(Guid sellingProductId)
        {
            var model = dbContext.SellingProducts.FirstOrDefault(p => p.Id == sellingProductId);
            dbContext.SellingProducts.Remove(model);
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<SellingProduct> GetSellingProduct(Guid sellingProductId) =>
            Task.FromResult(dbContext.SellingProducts.FirstOrDefault(p => p.Id == sellingProductId));

        public Task<List<SellingProduct>> GetSellingProducts() =>
            Task.FromResult(dbContext.SellingProducts.OrderBy(p => p.CreatedTime).ToList());

        public Task<SellingProduct> UpdateSellingProduct(SellingProduct sellingProduct)
        {
            dbContext.SellingProducts.Update(sellingProduct);
            dbContext.SaveChanges();
            return Task.FromResult(sellingProduct);
        }
    }
}
