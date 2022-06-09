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
    public class BrandRepo : IBrandInterface
    {
        private readonly ApplicationDbContext dbContext;

        public BrandRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<Brand> AddBrand(Brand brand)
        {
            dbContext.Brands.Add(brand);
            dbContext.SaveChanges();
            return Task.FromResult(brand);
        }

        public Task DeleteBrand(Guid brandId)
        {
            var model = dbContext.Brands.FirstOrDefault(p => p.Id == brandId);
            dbContext.Brands.Remove(model);
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<Brand> GetBrand(Guid brandId) =>
            Task.FromResult(dbContext.Brands.FirstOrDefault(p => p.Id == brandId));
        public Task<List<Brand>> GetBrands() =>
            Task.FromResult(dbContext.Brands.OrderBy(p => p.Name).ToList());

        public Task<Brand> UpdateBrand(Brand brand)
        {
            dbContext.Brands.Update(brand);
            dbContext.SaveChanges();
            return Task.FromResult(brand);
        }
    }
}
