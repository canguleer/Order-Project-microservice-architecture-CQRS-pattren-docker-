using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Entities;
using OrderProject.Infrastructure.Configurations;
using OrderProject.Infrastructure.Seeds;

namespace Ordering.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ProductConfiguration içinde yaptığım tablo kolon özelliklerini burada da yapabilirdim ama bu alanı temiz tutmak adına ayrı bir class içinde  yazıldı..
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderSeed(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }));

        }
    }
}
