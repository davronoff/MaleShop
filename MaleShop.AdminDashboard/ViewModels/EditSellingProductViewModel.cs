using MaleShop.Domains;
using System.ComponentModel.DataAnnotations;

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
        public IFormFile? NewImage { get; set; }

        public static explicit operator EditSellingProductViewModel(SellingProduct m)
        {
            return new EditSellingProductViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Size = m.Size,
                Color = m.Color,
                Price = m.Price,
                Image = m.Image,
                CreatedTime = m.CreatedTime,
                BrandId = m.BrandId,
                CategoryId = m.CategoryId,
            };
        }
        public static explicit operator SellingProduct(EditSellingProductViewModel v)
        {
            return new SellingProduct()
            {
                Id = v.Id,
                Name = v.Name,
                Size = v.Size,
                Color = v.Color,
                Price = v.Price,
                Image = v.Image,
                CreatedTime = v.CreatedTime,
                BrandId = v.BrandId,
                CategoryId = v.CategoryId
            };
        }
    }
}
