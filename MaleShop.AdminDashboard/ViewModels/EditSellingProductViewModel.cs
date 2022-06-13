using MaleShop.Domains;

namespace MaleShop.AdminDashboard.ViewModels
{
    public class EditSellingProductViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }

        public static explicit operator EditSellingProductViewModel(SellingProduct m)
        {
            return new EditSellingProductViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Size = m.Size,
                Color = m.Color,
                Image = m.Image,
                CreatedTime = m.CreatedTime,
                BrandId = m.BrandId,
                CategoryId = m.CategoryId
            };
        }
    }
}
