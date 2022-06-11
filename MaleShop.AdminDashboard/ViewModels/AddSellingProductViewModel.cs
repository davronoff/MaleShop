using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class AddSellingProductViewModel
    {
         public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public double Price { get; set; }
        public IFormFile? Image { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
