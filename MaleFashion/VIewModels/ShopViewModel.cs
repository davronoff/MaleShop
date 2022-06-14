using MaleShop.Domains;

namespace MaleFashion.VIewModels
{
    public class ShopViewModel
    {
        public List<SellingProduct>? SellingProducts { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Brand>? Brands { get; set; }
    }
}
