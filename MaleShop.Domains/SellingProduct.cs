namespace MaleShop.Domains
{
    public class SellingProduct
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public double Price { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
    }
}