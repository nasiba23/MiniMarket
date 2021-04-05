using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
            (
                new Category
                {
                    Id = 1,
                    Name = "Phone",
                },
                new Category
                {
                    Id = 2,
                    Name = "Home appliances",
                },
                new Category
                {
                    Id = 3,
                    Name = "Furniture",
                },
                new Category
                {
                    Id = 4,
                    Name = "Other",
                }
            );
        }
    }
}