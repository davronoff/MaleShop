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
        public Task<Brand> AddBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBrand(Guid brandId)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> GetBrand(Guid brandId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Brand>> GetBrands()
        {
            throw new NotImplementedException();
        }

        public Task<Brand> UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
