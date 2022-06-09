using MaleShop.Domains;
using Microsoft.EntityFrameworkCore;

namespace MaleShop.Data
{
    public class ApplicationDbContext: DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<SellingProduct> SellingProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}