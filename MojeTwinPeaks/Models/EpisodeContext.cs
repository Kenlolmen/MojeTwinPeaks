using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MojeTwinPeaks.Models
{
    public class EpisodeContext : DbContext
    {
        public DbSet<Episode> Episodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Dont be to curious");
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
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E1.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 2, SeasonID = 1, EpisodeNumber = 2, Title = "Traces to Nowhere",
                    Description = "Agent Cooper enjoys the comforts of the Great Northern Hotel. Bobby Briggs and Mike Nelson are released from jail. " +
                    "Doctor Hayward hands over the autopsy report on Laura Palmer.",
                    ReleaseDate = new DateTime(1990, 4, 12),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E2.jpg",
                    ImdbRating = 8.2
                },
                new Episode
                {
                    ID = 3, SeasonID = 1, EpisodeNumber = 3, Title = "Zen, or the Skill to Catch a Killer",
                    Description = "Ben Horne's brother, Jerry, arrives in Twin Peaks; together they travel to One Eyed Jack's and meet with the madam, Blackie O'Reilly." +
                    " Audrey leaves a clue for Cooper. Deputy Hawk finds a bloody towel near the crime scene.",
                    ReleaseDate = new DateTime(1990, 4, 19),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E3.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 4, SeasonID = 1, EpisodeNumber = 4, Title = "Rest in Pain",
                    Description = "Cooper meets with Audrey, who confesses to leaving him the note about One Eyed Jack's." +
                    " Cooper tells Truman he can't remember who the killer was in his dream, but insists the dream is a code to solving the crime.",
                    ReleaseDate = new DateTime(1990, 4, 26),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E4.jpg",
                    ImdbRating = 8.2
                },
                new Episode
                {
                    ID = 5, SeasonID = 1, EpisodeNumber = 5, Title = "The One-Armed Man",
                    Description = "Cooper questions Dr. Jacoby, who suspects Leo Johnson is the killer. Gordon Cole, Cooper's supervisor, calls in with Albert's report." +
                    "Josie Packard spies on Ben Horne and Catherine Martell. Hawk tracks down the One-Armed Man.",
                    ReleaseDate = new DateTime(1990, 5, 3),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E5.jpg",
                    ImdbRating = 8.1
                },
                new Episode
                {
                    ID = 6, SeasonID = 1, EpisodeNumber = 6, Title = "Cooper's Dreams",
                    Description = "Cooper and company have tea with the Log Lady, who tells them there was a third man following after Leo and Jacques the night Laura died." +
                    " At Jacques Renault's cabin Cooper, Hawk, and Truman find Waldo the bird.",
                    ReleaseDate = new DateTime(1990, 5, 10),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E6.jpg",
                    ImdbRating = 8.4
                },
                new Episode
                {
                    ID = 7, SeasonID = 1, EpisodeNumber = 7, Title = "Realization Time",
                    Description = "Audrey cons her way into working at the perfume counter where Laura worked and discovers that it's being used as a recruitment post for One Eyed Jack's." +
                    " James, Donna and Maddy plan to lure Jacoby away from his office.",
                    ReleaseDate = new DateTime(1990, 5, 17),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E7.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 8, SeasonID = 1, EpisodeNumber = 8, Title = "The Last Evening",
                    Description = "Audrey is hired at One Eyed Jack's, but is caught in a trap when her father arrives. Cooper gets Jacques Renault to reveal the details of" +
                    " Laura's last night in the cabin. Deputy Andy saves Truman's life and apprehends Renault.",
                    ReleaseDate = new DateTime(1990, 5, 23),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E8.jpg",
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
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E1.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 10, SeasonID = 2, EpisodeNumber = 2, Title = "Coma",
                    Description = "Albert determines that neither Leo nor Jacques killed Laura, but he is unable to find any leads into who shot Cooper." +
                    " Cooper says they must find the third man, who he believes to be Bob, the gray-haired man.",
                    ReleaseDate = new DateTime(1990, 10, 6),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E2.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 11, SeasonID = 2, EpisodeNumber = 3, Title = "The Man Behind the Glass",
                    Description = "Ronette is attacked in her hospital bed by an unseen person. Jean Renault, brother of Jacques and Bernard, plans to blackmail Ben Horne for the release of Audrey." +
                    " Donna meets with Harold Smith, a shut-in who had befriended Laura.",
                    ReleaseDate = new DateTime(1990, 10, 13),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E3.jpg",
                    ImdbRating = 8.1
                },
                new Episode
                {
                    ID = 12, SeasonID = 2, EpisodeNumber = 4, Title = "Laura's Secret Diary",
                    Description = "Leland confesses to killing Jacques Renault. Andy wants to take a new sperm count test. Rumor spreads that a food critic is coming to Twin Peaks." +
                    " Jean asks Ben to set a trap for Cooper in exchange for Audrey's life.",
                    ReleaseDate = new DateTime(1990, 10, 20),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E4.jpg",
                    ImdbRating = 8.0
                },
                new Episode
                {
                    ID = 13, SeasonID = 2, EpisodeNumber = 5, Title = "The Orchid's Curse",
                    Description = "Cooper remembers the message under his bed. Shelly and Bobby begin Leo's home care. Sternwood hears pretrial motions and declares Leo not fit for trial." +
                    " Nadine comes home, still thinking she's in high school.",
                    ReleaseDate = new DateTime(1990, 10, 27),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E5.jpg",
                    ImdbRating = 8.3
                },
                new Episode
                {
                    ID = 14, SeasonID = 2, EpisodeNumber = 6, Title = "Demons",
                    Description = "James saves the girls from a tormented Harold. Cooper brings Audrey home. Bobby and Shelly learn that their insurance plans have backfired." +
                    " Donna tries to convince Truman that Harold Smith has Laura's secret diary. ",
                    ReleaseDate = new DateTime(1990, 11, 3),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E6.jpg",
                    ImdbRating = 8.4
                },
                new Episode
                {
                    ID = 15, SeasonID = 2, EpisodeNumber = 7, Title = "Lonely Souls",
                    Description = "Cooper and the One-Armed Man inspect guests at the Great Northern. Hawk finds Harold Smith dead -" +
                    " with a mysterious suicide note and the diary torn to shreds. Leo speaks to Bobby about 'new shoes'. ",
                    ReleaseDate = new DateTime(1990, 11, 10),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E7.jpg",
                    ImdbRating = 9.4
                },
                new Episode
                {
                    ID = 16, SeasonID = 2, EpisodeNumber = 8, Title = "Drive with a Dead Girl",
                    Description = "Donna and James wonder why Maddy left so suddenly. Norma's mother arrives with the news that she's married a new man, " +
                    "Ernie Niles. Cooper tells Leland they arrested Ben Horne for Laura's murder. ",
                    ReleaseDate = new DateTime(1990, 11, 17),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E8.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 17, SeasonID = 2, EpisodeNumber = 9, Title = "Arbitrary Law",
                    Description = "Albert returns to examine Maddy. Cooper asks for 24 hours to finish his case. James and Donna reaffirm their love." +
                    " Andy accidentally leads Donna and Cooper back to Mrs. Tremond's house.",
                    ReleaseDate = new DateTime(1990, 12, 1),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E9.jpg",
                    ImdbRating = 9.3
                },
                new Episode
                {
                    ID = 18, SeasonID = 2, EpisodeNumber = 10, Title = "Dispute Between Brothers",
                    Description = "Leland is laid to rest and Sarah Palmer tries to accept all that has happened to her family. Dr. Jacoby returns from Hawaii. " +
                    "Cooper prepares to leave Twin Peaks. Mayor Milford objects to his brother's engagement to a younger woman.",
                    ReleaseDate = new DateTime(1990, 12, 8),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E10.jpg",
                    ImdbRating = 7.7
                },
                new Episode
                {
                    ID = 19, SeasonID = 2, EpisodeNumber = 11, Title = "Masked Ball",
                    Description = "Mrs. Briggs talks about her husband's disappearance into the woods. Nadine is put on the wrestling team," +
                    " where she falls for Mike Nelson. James is hired by the mysterious, wealthy Evelyn Marsh. Dick takes on an orphan, Little Nicky.",
                    ReleaseDate = new DateTime(1990, 12, 15),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E11.jpg",
                    ImdbRating = 7.3
                },
                new Episode
                {
                    ID = 20, SeasonID = 2, EpisodeNumber = 12, Title = "The Black Widow",
                    Description = "Ben takes Bobby under his wing in a hope to destroy Hank and Jean. However, Ben's mental state is starting to crack." +
                    " Cooper starts to look at buying real estate. Major Briggs's supervisor reveals that Briggs was studying the woods..",
                    ReleaseDate = new DateTime(1991, 1, 12),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E12.jpg",
                    ImdbRating = 7.3
                },
                new Episode
                {
                    ID = 21, SeasonID = 2, EpisodeNumber = 13, Title = "Checkmate",
                    Description = "Major Briggs has no memory of the place he was taken, but now has an odd tattoo on his neck. Andy and Dick break into Little Nicky's files." +
                    " Mike and Nadine begin an affair. Evelyn asks James to kill her husband.",
                    ReleaseDate = new DateTime(1991, 1, 19),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E13.jpg",
                    ImdbRating = 7.6
                },
                new Episode
                {
                    ID = 22, SeasonID = 2, EpisodeNumber = 14, Title = "Double Play",
                    Description = "Windom Earle has taken his first victim in the deadly chess game. Audrey tells Bobby they have to save Ben from his civil war fantasy." +
                    " Leo awakes and attacks Shelly, but Bobby is able to fend him off.",
                    ReleaseDate = new DateTime(1991, 2, 2),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E14.jpg",
                    ImdbRating = 7.5
                },
                new Episode
                {
                    ID = 23, SeasonID = 2, EpisodeNumber = 15, Title = "Slaves and Masters",
                    Description = "The police look for James in the Marsh murder. Bobby and Shelly tell Truman that Leo escaped; and Bobby reveals that he saw Hank shoot Leo the night the mill burned." +
                    " Albert returns to Twin Peaks with information on Windom Earle.",
                    ReleaseDate = new DateTime(1991, 2, 9),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E15.jpg",
                    ImdbRating = 7.1
                },
                new Episode
                {
                    ID = 24, SeasonID = 2, EpisodeNumber = 16, Title = "The Condemned Woman",
                    Description = "Truman puts Hank in prison for the attempted murder of Leo, while Hank points the finger at Josie for the murder of Andrew Packard." +
                    " Albert reveals that Josie shot Cooper. Ben enlists the help of John Justice Wheeler.",
                    ReleaseDate = new DateTime(1991, 2, 16),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E16.jpg",
                    ImdbRating = 7.7
                },
                new Episode
                {
                    ID = 25, SeasonID = 2, EpisodeNumber = 17, Title = "Wounds and Scars",
                    Description = "Harry sinks into a deep depression after Josie's death. Josie's body holds more questions than answers. Norma's troubled sister, " +
                    "Annie, arrives in Twin Peaks. Wheeler and Audrey hit it off. Cooper's stalemate angers Earle.",
                    ReleaseDate = new DateTime(1991, 3, 28),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E17.jpg",
                    ImdbRating = 7.3
                },
                new Episode
                {
                    ID = 26, SeasonID = 2, EpisodeNumber = 18, Title = "On the Wings of Love",
                    Description = "Harry is attacked by Jones in his sleep. Audrey and Wheeler begin a relationship. Gordon Cole returns with a report that Windom Earle worked with Major Briggs on Project Bluebook." +
                    " Cole reinstates Cooper in the FBI.",
                    ReleaseDate = new DateTime(1991, 4, 4),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E18.jpg",
                    ImdbRating = 7.9
                },
                new Episode
                {
                    ID = 27, SeasonID = 2, EpisodeNumber = 19, Title = "Variations and Relations",
                    Description = "Cooper and company find the mysterious petroglyph. Windom Earle befriends a rock 'n' roll youth, and tells him tales of places called the White and Black Lodge. " +
                    "Pete helps Catherine open the first puzzle box.",
                    ReleaseDate = new DateTime(1991, 4, 11),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E19.jpg",
                    ImdbRating = 7.8
                },
                new Episode
                {
                    ID = 28, SeasonID = 2, EpisodeNumber = 20, Title = "The Path to the Black Lodge",
                    Description = "Bobby and Shelly reaffirm their love. Cooper calls Shelly, Donna and Audrey together to warn them about Earle." +
                    " Briggs shows Cooper a tape of Windom Earle making a report on his quest for the Black Lodge.",
                    ReleaseDate = new DateTime(1991, 4, 18),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E20.jpg",
                    ImdbRating = 8.1
                },
                new Episode
                {
                    ID = 29, SeasonID = 2, EpisodeNumber = 21, Title = "Miss Twin Peaks",
                    Description = "Windom Earle sets his sights on the Miss Twin Peaks contest. Lucy chooses a father for her baby. Leo is punished when he frees Major Briggs. Cooper unlocks the key to entering the Black Lodge. " +
                    "Annie and Dale make a commitment.",
                    ReleaseDate = new DateTime(1991, 6, 10),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E21.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 30, SeasonID = 2, EpisodeNumber = 22, Title = "Beyond Life and Death",
                    Description = "Agent Cooper follows Windom Earle and Annie into the depths of the Black Lodge. Big Ed and Norma get a shock when Nadine suffers head trauma. " +
                    "Andrew and Pete unlock Eckhardt's final box and Audrey stages an act of civil disobedience.",
                    ReleaseDate = new DateTime(1991, 6, 10),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E22.jpg",
                    ImdbRating = 9.3
                },
                /// END OF 2ND SEASON
                /// 3RD SEASON
                new Episode
                {
                    ID = 31, SeasonID = 3, EpisodeNumber = 1, Title = "Part 1",
                    Description = "My log has a message for you.",
                    ReleaseDate = new DateTime(2017, 5, 21),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E1.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 32, SeasonID = 3, EpisodeNumber = 2, Title = "Part 2",
                    Description = "The stars turn and a time presents itself.",
                    ReleaseDate = new DateTime(2017, 5, 21),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E2.jpg",
                    ImdbRating = 8.6
                },
                new Episode
                {
                    ID = 33, SeasonID = 3, EpisodeNumber = 3, Title = "Part 3",
                    Description = "Call for help.",
                    ReleaseDate = new DateTime(2017, 5, 21),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E3.jpg",
                    ImdbRating = 8.4
                },
                new Episode
                {
                    ID = 34, SeasonID = 3, EpisodeNumber = 4, Title = "Part 4",
                    Description = "...brings back some memories.",
                    ReleaseDate = new DateTime(2017, 6, 21),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E4.jpg",
                    ImdbRating = 8.5
                },
                new Episode
                {
                    ID = 35, SeasonID = 3, EpisodeNumber = 5, Title = "Part 5",
                    Description = "Case files.",
                    ReleaseDate = new DateTime(2017, 6, 4),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E5.jpg",
                    ImdbRating = 8.0
                },
                new Episode
                {
                    ID = 36, SeasonID = 3, EpisodeNumber = 6, Title = "Part 6",
                    Description = "Don't die.",
                    ReleaseDate = new DateTime(2017, 6, 11),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E6.jpg",
                    ImdbRating = 8.0
                },
                new Episode
                {
                    ID = 37, SeasonID = 3, EpisodeNumber = 7, Title = "Part 7",
                    Description = "There's a body all right.",
                    ReleaseDate = new DateTime(2017, 6, 18),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E7.jpg",
                    ImdbRating = 8.6
                },
                new Episode
                {
                    ID = 38, SeasonID = 3, EpisodeNumber = 8, Title = "Part 8",
                    Description = "Got a light?",
                    ReleaseDate = new DateTime(2017, 6, 25),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E8.jpg",
                    ImdbRating = 8.8
                },
                new Episode
                {
                    ID = 39, SeasonID = 3, EpisodeNumber = 9, Title = "Part 9",
                    Description = "This is the chair.",
                    ReleaseDate = new DateTime(2017, 7, 9),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E9.jpg",
                    ImdbRating = 8.3
                },new Episode
                {
                    ID = 40, SeasonID = 3, EpisodeNumber = 10, Title = "Part 10",
                    Description = "Laura is the one.",
                    ReleaseDate = new DateTime(2017, 7, 16),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E10.jpg",
                    ImdbRating = 8.0
                },
                new Episode
                {
                    ID = 41, SeasonID = 3, EpisodeNumber = 11, Title = "Part 11",
                    Description = "There's fire where you are going.",
                    ReleaseDate = new DateTime(2017, 7, 23),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E11.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 42, SeasonID = 3, EpisodeNumber = 12, Title = "Part 12",
                    Description = "Let's rock.",
                    ReleaseDate = new DateTime(2017, 7, 30),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E12.jpg",
                    ImdbRating = 7.6
                },
                new Episode
                {
                    ID = 43, SeasonID = 3, EpisodeNumber = 13, Title = "Part 13",
                    Description = "What story is that, Charlie?",
                    ReleaseDate = new DateTime(2017, 8, 6),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E13.jpg",
                    ImdbRating = 8.3
                },
                new Episode
                {
                    ID = 44, SeasonID = 3, EpisodeNumber = 14, Title = "Part 14",
                    Description = "We are like the dreamer.",
                    ReleaseDate = new DateTime(2017, 8, 13),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E14.jpg",
                    ImdbRating = 8.9
                },
                new Episode
                {
                    ID = 45, SeasonID = 3, EpisodeNumber = 15, Title = "Part 15",
                    Description = "There's some fear in letting go.",
                    ReleaseDate = new DateTime(2017, 8, 20),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E15.jpg",
                    ImdbRating = 8.7
                },
                new Episode
                {
                    ID = 46, SeasonID = 3, EpisodeNumber = 16, Title = "Part 16",
                    Description = "No knock, no doorbell.",
                    ReleaseDate = new DateTime(2017, 8, 27),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E16.jpg",
                    ImdbRating = 9.5
                },
                new Episode
                {
                    ID = 47, SeasonID = 3, EpisodeNumber = 17, Title = "Part 17",
                    Description = "The past dictates the future.",
                    ReleaseDate = new DateTime(2017, 9, 3),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E17.jpg",
                    ImdbRating = 9.4
                },
                new Episode
                {
                    ID = 48, SeasonID = 3, EpisodeNumber = 18, Title = "Part 18",
                    Description = "What is your name?",
                    ReleaseDate = new DateTime(2017, 9, 3),
                    ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E18.jpg",
                    ImdbRating = 8.7
                }

            ); 
        }

    }
}
