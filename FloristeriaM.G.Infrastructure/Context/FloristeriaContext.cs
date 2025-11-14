using Microsoft.EntityFrameworkCore;
using FloristeriaMG.Domain.Entities;

namespace FloristeriaMG.Infrastructure.Context
{
    public class FloristeriaContext : DbContext
    {
        public FloristeriaContext(DbContextOptions<FloristeriaContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Occasion> Occasions { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Occasion)
                .WithMany(o => o.Products)
                .HasForeignKey(p => p.OccasionId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
