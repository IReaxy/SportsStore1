using Microsoft.EntityFrameworkCore;
using SportStore.Models;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
        public DbSet<Product> Products => Set<Product>();

        public DbSet<Cart> cart { get; set; }
    }
}
