using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.WebRequestMethods;

namespace MojeTwinPeaks.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) { }
        public DbSet<Music> MusicTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("-");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Music>().HasData(
                new Music
                {
                    ID = 1, Name = "Audrey's Dance", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/AudreysDance.jpg ",
                    YouTubeUrl = "https://youtu.be/nITuHzF4ryk"
                },
                new Music
                {
                    ID = 2, Name = "Dance Of The Dream Man", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/DanceOfTheDreamMan.jpg ",
                    YouTubeUrl = "https://youtu.be/kBn_lQBh9JA"
                },
                new Music
                {
                    ID = 3, Name = "Falling", Artist = "Julee Cruise", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/Falling.jpg ",
                    YouTubeUrl = "https://youtu.be/KkR6Jd0Agi4"
                },
                new Music
                {
                    ID = 4, Name = "Freshly Squeezed", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/FreshlySqueezed.jpg ",
                    YouTubeUrl = "https://youtu.be/bc-Prdyp9LY "
                },
                new Music
                {
                    ID = 5, Name = "Into The Night", Artist = "Julee Cruise", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/IntoTheNight.jpg ",
                    YouTubeUrl = "https://youtu.be/euq0sKwbDTg"
                },
                new Music
                {
                    ID = 6, Name = "Laura Palmers Theme", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/LauraPalmersTheme.jpg ",
                    YouTubeUrl = "https://youtu.be/woUt7wPe8Ow"
                },
                new Music
                {
                    ID = 7, Name = "Love Theme", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/LoveTheme.jpg ",
                    YouTubeUrl = "https://youtu.be/JwHwyejd-vk"
                },
                new Music
                {
                    ID = 8, Name = "The Bookhouse Boys", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TheBookhouseBoys.jpg ",
                    YouTubeUrl = "https://youtu.be/rQrVeoiebWs"
                },
                new Music
                {
                    ID = 9, Name = "The Nightingale", Artist = "Julee Cruise", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TheNightingale.jpg ",
                    YouTubeUrl = "https://youtu.be/BzImHGz4R0M"
                },
                new Music
                {
                    ID = 10, Name = "Twin Peaks Theme", Artist = "Angelo Badalamenti", 
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TwinPeaksTheme.jpg ",
                    YouTubeUrl = "https://youtu.be/nCn3LYqCnrk"
                }
                );
        }
    }
}
