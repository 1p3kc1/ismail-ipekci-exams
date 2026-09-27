using Microsoft.EntityFrameworkCore;
using MVC_MovieArchive.Models.Entities;

namespace MVC_MovieArchive.Models;

public class MovieArchiveDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12200;Database=movie_db;Username=movie_user;Password=movie_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Title = "Babam ve Oğlum",
                Director = "Çağan Irmak",
                ReleaseYear = 2005
            },
            new Movie
            {
                Id = 2,
                Title = "Hababam Sınıfı",
                Director = "Ertem Eğilmez",
                ReleaseYear = 1975
            },
            new Movie
            {
                Id = 3,
                Title = "Interstellar",
                Director = "Christopher Nolan",
                ReleaseYear = 2014
            },
            new Movie
            {
                Id = 4,
                Title = "Inception",
                Director = "Christopher Nolan",
                ReleaseYear = 2010
            },
            new Movie
            {
                Id = 5,
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                ReleaseYear = 1972
            },
            new Movie
            {
                Id = 6,
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                ReleaseYear = 1994
            },
            new Movie
            {
                Id = 7,
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                ReleaseYear = 1994
            },
            new Movie
            {
                Id = 8,
                Title = "The Matrix",
                Director = "Lana Wachowski ve Lilly Wachowski",
                ReleaseYear = 1999
            }
        );
    }
}