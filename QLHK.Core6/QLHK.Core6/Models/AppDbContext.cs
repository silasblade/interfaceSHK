using Microsoft.EntityFrameworkCore;

namespace QLHK.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<NhanKhau> NhanKhaus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // You can add additional configuration for your model here if needed
            // For example, configuring primary keys, relationships, etc.
        }
    }
}
