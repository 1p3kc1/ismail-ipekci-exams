using Microsoft.EntityFrameworkCore;
using MVC_GymMembers.Models.Entities;

namespace MVC_GymMembers.Models;

public class GymMembersDbContext : DbContext
{
    public DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12400;Database=gym_db;Username=gym_user;Password=gym_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>().HasData(
            new Member
            {
                Id = 1,
                FullName = "Ahmet Yıldız",
                MembershipType = "Yıllık",
                Age = 28
            },
            new Member
            {
                Id = 2,
                FullName = "Elif Kaya",
                MembershipType = "Aylık",
                Age = 24
            },
            new Member
            {
                Id = 3,
                FullName = "Mehmet Demir",
                MembershipType = "3 Aylık",
                Age = 31
            },
            new Member
            {
                Id = 4,
                FullName = "Zeynep Şahin",
                MembershipType = "Yıllık",
                Age = 27
            },
            new Member
            {
                Id = 5,
                FullName = "Can Arslan",
                MembershipType = "Aylık",
                Age = 22
            },
            new Member
            {
                Id = 6,
                FullName = "Ayşe Çelik",
                MembershipType = "3 Aylık",
                Age = 35
            },
            new Member
            {
                Id = 7,
                FullName = "Burak Koç",
                MembershipType = "Yıllık",
                Age = 29
            },
            new Member
            {
                Id = 8,
                FullName = "Merve Aydın",
                MembershipType = "Aylık",
                Age = 26
            }
        );
    }
}