using Microsoft.EntityFrameworkCore;
using System;

namespace QLHK.Core6.Models
{
    public class AppHKDbContext : DbContext
    {
        public AppHKDbContext(DbContextOptions<AppHKDbContext> options) : base(options)
        {
        }

        public DbSet<NhanKhau> NhanKhaus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanKhau>()
            .HasIndex(nk => nk.MaNhanKhau)
            .IsUnique();
        }
    }
}
