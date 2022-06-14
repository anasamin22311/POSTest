using Microsoft.EntityFrameworkCore;
using POSTest.Modelss;

namespace POSTest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Size> Sizes { get; set; }
    }
}
