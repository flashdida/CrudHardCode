using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> AttributeFields { get; set; }
        public DbSet<ProductAttributeValue> AttributeFieldProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductAttributeValue>()
                          .HasOne(ap => ap.Attribute)
                          .WithMany(a => a.AttributeFieldProducts)
                          .HasForeignKey(ap => ap.AttributeFieldId);
            modelBuilder.Entity<ProductAttributeValue>()
                          .HasOne(ap => ap.Product)
                          .WithMany(a => a.AttributeFieldProducts)
                          .HasForeignKey(ap => ap.ProductId);
        }
    }
}
