using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class IndexHomeViewModel
    {
        public List<Brand>? Brands { get; set; }
        public List<Category>? Categories { get; set; }
        public List<SellingProduct>? SellingProducts { get; set; }
    }
}
