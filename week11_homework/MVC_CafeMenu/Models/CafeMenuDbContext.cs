using Microsoft.EntityFrameworkCore;
using MVC_CafeMenu.Models.Entities;

namespace MVC_CafeMenu.Models;

public class CafeMenuDbContext : DbContext
{
    public DbSet<MenuItem> MenuItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12500;Database=cafe_db;Username=cafe_user;Password=cafe_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem
            {
                Id = 1,
                Name = "Türk Kahvesi",
                Category = "Sıcak İçecek",
                Price = 90
            },
            new MenuItem
            {
                Id = 2,
                Name = "Latte",
                Category = "Sıcak İçecek",
                Price = 120
            },
            new MenuItem
            {
                Id = 3,
                Name = "Americano",
                Category = "Sıcak İçecek",
                Price = 100
            },
            new MenuItem
            {
                Id = 4,
                Name = "Limonata",
                Category = "Soğuk İçecek",
                Price = 95
            },
            new MenuItem
            {
                Id = 5,
                Name = "Soğuk Kahve",
                Category = "Soğuk İçecek",
                Price = 130
            },
            new MenuItem
            {
                Id = 6,
                Name = "Cheesecake",
                Category = "Tatlı",
                Price = 150
            },
            new MenuItem
            {
                Id = 7,
                Name = "Brownie",
                Category = "Tatlı",
                Price = 125
            },
            new MenuItem
            {
                Id = 8,
                Name = "Kaşarlı Tost",
                Category = "Yiyecek",
                Price = 110
            }
        );
    }
}