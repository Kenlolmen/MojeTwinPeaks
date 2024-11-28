using Microsoft.EntityFrameworkCore;

namespace MojeTwinPeaks.Models
{
    public class EpisodeContext : DbContext
    {
        public DbSet<Episode> Episodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = MojeTwinPeaks; Trusted_Connection = true; MultipleActiveResultSets = true; ");
        }


        // Episodes Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Episode>().HasData(
                new Episode
                {
                    ID = 1, SeasonID = 1, EpisodeNumber = 1, Title = "Northwest Passage",
                    Description = "The small northwest town of Twin Peaks, Washington is shaken up when the body of the Homecoming Queen, " +
                    "Laura Palmer, is discovered washed up on a riverbank, wrapped in plastic.",
                    ReleaseDate = new DateTime(1990, 4, 8),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E1.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 2, SeasonID = 1, EpisodeNumber = 2, Title = "Traces to Nowhere",
                    Description = "Agent Cooper enjoys the comforts of the Great Northern Hotel. Bobby Briggs and Mike Nelson are released from jail. " +
                    "Doctor Hayward hands over the autopsy report on Laura Palmer.",
                    ReleaseDate = new DateTime(1990, 4, 12),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E2.jpg",
                    ImdbRating = 8.2
                },
                new Episode
                {
                    ID = 3, SeasonID = 1, EpisodeNumber = 3, Title = "Zen, or the Skill to Catch a Killer",
                    Description = "Ben Horne's brother, Jerry, arrives in Twin Peaks; together they travel to One Eyed Jack's and meet with the madam, Blackie O'Reilly." +
                    " Audrey leaves a clue for Cooper. Deputy Hawk finds a bloody towel near the crime scene.",
                    ReleaseDate = new DateTime(1990, 4, 19),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E3.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 4, SeasonID = 1, EpisodeNumber = 4, Title = "Rest in Pain",
                    Description = "Cooper meets with Audrey, who confesses to leaving him the note about One Eyed Jack's." +
                    " Cooper tells Truman he can't remember who the killer was in his dream, but insists the dream is a code to solving the crime.",
                    ReleaseDate = new DateTime(1990, 4, 26),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E4.jpg",
                    ImdbRating = 8.2
                },
                new Episode
                {
                    ID = 5, SeasonID = 1, EpisodeNumber = 5, Title = "The One-Armed Man",
                    Description = "Cooper questions Dr. Jacoby, who suspects Leo Johnson is the killer. Gordon Cole, Cooper's supervisor, calls in with Albert's report." +
                    "Josie Packard spies on Ben Horne and Catherine Martell. Hawk tracks down the One-Armed Man.",
                    ReleaseDate = new DateTime(1990, 5, 3),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E5.jpg",
                    ImdbRating = 8.1
                },
                new Episode
                {
                    ID = 6, SeasonID = 1, EpisodeNumber = 6, Title = "Cooper's Dreams",
                    Description = "Cooper and company have tea with the Log Lady, who tells them there was a third man following after Leo and Jacques the night Laura died." +
                    " At Jacques Renault's cabin Cooper, Hawk, and Truman find Waldo the bird.",
                    ReleaseDate = new DateTime(1990, 5, 10),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E6.jpg",
                    ImdbRating = 8.4
                },
                new Episode
                {
                    ID = 7, SeasonID = 1, EpisodeNumber = 7, Title = "Realization Time",
                    Description = "Audrey cons her way into working at the perfume counter where Laura worked and discovers that it's being used as a recruitment post for One Eyed Jack's." +
                    " James, Donna and Maddy plan to lure Jacoby away from his office.",
                    ReleaseDate = new DateTime(1990, 5, 17),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E7.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 8, SeasonID = 1, EpisodeNumber = 8, Title = "The Last Evening",
                    Description = "Audrey is hired at One Eyed Jack's, but is caught in a trap when her father arrives. Cooper gets Jacques Renault to reveal the details of" +
                    " Laura's last night in the cabin. Deputy Andy saves Truman's life and apprehends Renault.",
                    ReleaseDate = new DateTime(1990, 5, 23),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S1E8.jpg",
                    ImdbRating = 9.0
                },
                /// END OF SEASON 1 
                /// SEASON 2
                new Episode
                {
                    ID = 9, SeasonID = 2, EpisodeNumber = 1, Title = "May the Giant Be with You",
                    Description = "A wounded Agent Cooper has a vision of a giant who gives him several clues about the murder of Laura Palmer. " +
                    "Shelly and Pete recover from the mill fire, but Josie and Catherine are missing.",
                    ReleaseDate = new DateTime(1990, 9, 30),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E1.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 10, SeasonID = 2, EpisodeNumber = 2, Title = "Coma",
                    Description = "Albert determines that neither Leo nor Jacques killed Laura, but he is unable to find any leads into who shot Cooper." +
                    " Cooper says they must find the third man, who he believes to be Bob, the gray-haired man.",
                    ReleaseDate = new DateTime(1990, 10, 6),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E2.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 11, SeasonID = 2, EpisodeNumber = 3, Title = "The Man Behind the Glass",
                    Description = "Ronette is attacked in her hospital bed by an unseen person. Jean Renault, brother of Jacques and Bernard, plans to blackmail Ben Horne for the release of Audrey." +
                    " Donna meets with Harold Smith, a shut-in who had befriended Laura.",
                    ReleaseDate = new DateTime(1990, 10, 13),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E3.jpg",
                    ImdbRating = 8.1
                },
                new Episode
                {
                    ID = 12, SeasonID = 2, EpisodeNumber = 4, Title = "Laura's Secret Diary",
                    Description = "Leland confesses to killing Jacques Renault. Andy wants to take a new sperm count test. Rumor spreads that a food critic is coming to Twin Peaks." +
                    " Jean asks Ben to set a trap for Cooper in exchange for Audrey's life.",
                    ReleaseDate = new DateTime(1990, 10, 20),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E4.jpg",
                    ImdbRating = 8.0
                },
                new Episode
                {
                    ID = 13, SeasonID = 2, EpisodeNumber = 5, Title = "The Orchid's Curse",
                    Description = "Cooper remembers the message under his bed. Shelly and Bobby begin Leo's home care. Sternwood hears pretrial motions and declares Leo not fit for trial." +
                    " Nadine comes home, still thinking she's in high school.",
                    ReleaseDate = new DateTime(1990, 10, 27),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E5.jpg",
                    ImdbRating = 8.3
                },
                new Episode
                {
                    ID = 14, SeasonID = 2, EpisodeNumber = 6, Title = "Demons",
                    Description = "James saves the girls from a tormented Harold. Cooper brings Audrey home. Bobby and Shelly learn that their insurance plans have backfired." +
                    " Donna tries to convince Truman that Harold Smith has Laura's secret diary. ",
                    ReleaseDate = new DateTime(1990, 11, 3),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E6.jpg",
                    ImdbRating = 8.4
                },
                new Episode
                {
                    ID = 15, SeasonID = 2, EpisodeNumber = 7, Title = "Lonely Souls",
                    Description = "Cooper and the One-Armed Man inspect guests at the Great Northern. Hawk finds Harold Smith dead -" +
                    " with a mysterious suicide note and the diary torn to shreds. Leo speaks to Bobby about 'new shoes'. ",
                    ReleaseDate = new DateTime(1990, 11, 10),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E7.jpg",
                    ImdbRating = 9.4
                },
                new Episode
                {
                    ID = 16, SeasonID = 2, EpisodeNumber = 8, Title = "Drive with a Dead Girl",
                    Description = "Donna and James wonder why Maddy left so suddenly. Norma's mother arrives with the news that she's married a new man, " +
                    "Ernie Niles. Cooper tells Leland they arrested Ben Horne for Laura's murder. ",
                    ReleaseDate = new DateTime(1990, 11, 17),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E8.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 17, SeasonID = 2, EpisodeNumber = 9, Title = "Arbitrary Law",
                    Description = "Albert returns to examine Maddy. Cooper asks for 24 hours to finish his case. James and Donna reaffirm their love." +
                    " Andy accidentally leads Donna and Cooper back to Mrs. Tremond's house.",
                    ReleaseDate = new DateTime(1990, 12, 1),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E9.jpg",
                    ImdbRating = 9.3
                },
                new Episode
                {
                    ID = 18, SeasonID = 2, EpisodeNumber = 10, Title = "Dispute Between Brothers",
                    Description = "Leland is laid to rest and Sarah Palmer tries to accept all that has happened to her family. Dr. Jacoby returns from Hawaii. " +
                    "Cooper prepares to leave Twin Peaks. Mayor Milford objects to his brother's engagement to a younger woman.",
                    ReleaseDate = new DateTime(1990, 12, 8),
                    ImagePath = "C:\\Users\\Lenovo\\source\\repos\\MojeTwinPeaks\\MojeTwinPeaks\\Data\\Episodes\\Image\\S2E10.jpg",
                    ImdbRating = 7.7
                }
            ); 
        }

    }
}
