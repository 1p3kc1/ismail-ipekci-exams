using System;
using Microsoft.EntityFrameworkCore;
using MVC_Library.Models.Entities;

namespace MVC_Library.Models;

public class LibraryDbContext :DbContext
{
    public DbSet<Book> Books {get; set;}


      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=12100;Database=lib_db;Username=lib_user;Password=lib_password");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Suç ve Ceza",
                    Author = "Fyodor Dostoyevski",
                    PageCount = 687
                },
                new Book
                {
                    Id = 2,
                    Title = "Sefiller",
                    Author = "Victor Hugo",
                    PageCount = 1232
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    PageCount = 328
                },
                new Book
                {
                    Id = 4,
                    Title = "Kürk Mantolu Madonna",
                    Author = "Sabahattin Ali",
                    PageCount = 160
                },
                new Book
                {
                    Id = 5,
                    Title = "Tutunamayanlar",
                    Author = "Oğuz Atay",
                    PageCount = 724
                },
                new Book
                {
                    Id = 6,
                    Title = "Simyacı",
                    Author = "Paulo Coelho",
                    PageCount = 184
                },
                new Book
                {
                    Id = 7,
                    Title = "Dönüşüm",
                    Author = "Franz Kafka",
                    PageCount = 104
                },
                new Book
                {
                    Id = 8,
                    Title = "Beyaz Diş",
                    Author = "Jack London",
                    PageCount = 256
                }
            );
        }
    }


