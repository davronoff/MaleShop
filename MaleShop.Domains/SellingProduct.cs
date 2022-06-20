using System.ComponentModel.DataAnnotations;

namespace MaleShop.Domains
{
    public class SellingProduct
    {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Size { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
    }
}