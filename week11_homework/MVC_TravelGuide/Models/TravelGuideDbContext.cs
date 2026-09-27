using Microsoft.EntityFrameworkCore;
using MVC_TravelGuide.Models.Entities;

namespace MVC_TravelGuide.Models;

public class TravelGuideDbContext : DbContext
{
    public DbSet<Place> Places { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12600;Database=travel_db;Username=travel_user;Password=travel_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Place>().HasData(
            new Place
            {
                Id = 1,
                Name = "Topkapı Sarayı",
                City = "İstanbul",
                EntryFee = 1400
            },
            new Place
            {
                Id = 2,
                Name = "Anıtkabir",
                City = "Ankara",
                EntryFee = 0
            },
            new Place
            {
                Id = 3,
                Name = "Efes Antik Kenti",
                City = "İzmir",
                EntryFee = 900
            },
            new Place
            {
                Id = 4,
                Name = "Pamukkale Travertenleri",
                City = "Denizli",
                EntryFee = 700
            },
            new Place
            {
                Id = 5,
                Name = "Göreme Açık Hava Müzesi",
                City = "Nevşehir",
                EntryFee = 600
            },
            new Place
            {
                Id = 6,
                Name = "Sümela Manastırı",
                City = "Trabzon",
                EntryFee = 500
            },
            new Place
            {
                Id = 7,
                Name = "Mevlana Müzesi",
                City = "Konya",
                EntryFee = 0
            },
            new Place
            {
                Id = 8,
                Name = "Safranbolu Evleri",
                City = "Karabük",
                EntryFee = 0
            }
        );
    }
}