using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MojeTwinPeaks.Models
{
    public class SeasonContext : DbContext
    {
        DbSet<Season> Seasons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Dont be to curious");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Season>().HasData(
                new Season
                {
                    ID = 1,
                    Episodes = 8,
                    ReleaseDate = new DateTime(1990, 4, 12)
                },
                new Season
                {
                    ID = 2,
                    Episodes = 22,
                    ReleaseDate = new DateTime(1990, 9, 30)
                },
                new Season
                {
                    ID = 3,
                    Episodes = 18,
                    ReleaseDate = new DateTime(2017, 5, 21)
                }
            );
        } 
    }
}
