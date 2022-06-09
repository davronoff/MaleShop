using MaleShop.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Repositories.Interface
{
    public interface ISellingProductInterface
    {
        Task<List<SellingProduct>> GetSellingProducts();
        Task<SellingProduct> GetSellingProduct(Guid sellingProductId);
        Task<SellingProduct> AddSellingProduct(SellingProduct sellingProduct);
        Task<SellingProduct> UpdateSellingProduct(SellingProduct sellingProduct);
        Task DeleteSellingProduct(Guid sellingProductId);
    }
}
