using Microsoft.EntityFrameworkCore;
using Shop.Infrastructure.EntitiesDB;

namespace Shop.Infrastructure.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDB>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }

        public DbSet<EntitiesDB.ProductDB> ProductDB { get; set; }
    }
}
