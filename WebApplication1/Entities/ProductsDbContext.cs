using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities
{
    public class ProductsDbContext : DbContext
    {

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set;}
        public DbSet<Inventory> Inventories { get; set;}
        public DbSet<Price> Prices { get; set;}
    }
}
