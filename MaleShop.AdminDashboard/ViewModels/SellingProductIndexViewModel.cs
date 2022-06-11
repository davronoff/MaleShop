using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class SellingProductIndexViewModel
    {
        public List<SellingProduct>? SellingProducts { get; set; }
        public List<Brand>? Brands { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
