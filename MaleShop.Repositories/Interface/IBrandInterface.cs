using MaleShop.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Repositories.Interface
{
    public interface IBrandInterface
    {
        Task<List<Brand>> GetBrands();
        Task<Brand> GetBrand(Guid brandId);
        Task<Brand> AddBrand(Brand brand);
        Task<Brand> UpdateBrand(Brand brand);
        Task DeleteBrand(Guid brandId);
        Task<List<Brand>> GetBrandBySPBrandId(Guid brandId);
    }
}
