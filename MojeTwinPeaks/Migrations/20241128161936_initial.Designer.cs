﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MojeTwinPeaks.Models;

#nullable disable

namespace MojeTwinPeaks.Migrations
{
    [DbContext(typeof(EpisodeContext))]
    [Migration("20241128161936_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MojeTwinPeaks.Models.Episode", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ImdbRating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeasonID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "The small northwest town of Twin Peaks, Washington is shaken up when the body of the Homecoming Queen, Laura Palmer, is discovered washed up on a riverbank, wrapped in plastic.",
                            EpisodeNumber = 1,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E1.jpg",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(1990, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Northwest Passage"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Agent Cooper enjoys the comforts of the Great Northern Hotel. Bobby Briggs and Mike Nelson are released from jail. Doctor Hayward hands over the autopsy report on Laura Palmer.",
                            EpisodeNumber = 2,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E2.jpg",
                            ImdbRating = 8.1999999999999993,
                            ReleaseDate = new DateTime(1990, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Traces to Nowhere"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Ben Horne's brother, Jerry, arrives in Twin Peaks; together they travel to One Eyed Jack's and meet with the madam, Blackie O'Reilly. Audrey leaves a clue for Cooper. Deputy Hawk finds a bloody towel near the crime scene.",
                            EpisodeNumber = 3,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E3.jpg",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(1990, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Zen, or the Skill to Catch a Killer"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Cooper meets with Audrey, who confesses to leaving him the note about One Eyed Jack's. Cooper tells Truman he can't remember who the killer was in his dream, but insists the dream is a code to solving the crime.",
                            EpisodeNumber = 4,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E4.jpg",
                            ImdbRating = 8.1999999999999993,
                            ReleaseDate = new DateTime(1990, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Rest in Pain"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Cooper questions Dr. Jacoby, who suspects Leo Johnson is the killer. Gordon Cole, Cooper's supervisor, calls in with Albert's report.Josie Packard spies on Ben Horne and Catherine Martell. Hawk tracks down the One-Armed Man.",
                            EpisodeNumber = 5,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E5.jpg",
                            ImdbRating = 8.0999999999999996,
                            ReleaseDate = new DateTime(1990, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "The One-Armed Man"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Cooper and company have tea with the Log Lady, who tells them there was a third man following after Leo and Jacques the night Laura died. At Jacques Renault's cabin Cooper, Hawk, and Truman find Waldo the bird.",
                            EpisodeNumber = 6,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E6.jpg",
                            ImdbRating = 8.4000000000000004,
                            ReleaseDate = new DateTime(1990, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Cooper's Dreams"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Audrey cons her way into working at the perfume counter where Laura worked and discovers that it's being used as a recruitment post for One Eyed Jack's. James, Donna and Maddy plan to lure Jacoby away from his office.",
                            EpisodeNumber = 7,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E7.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(1990, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "Realization Time"
                        },
                        new
                        {
                            ID = 8,
                            Description = "Audrey is hired at One Eyed Jack's, but is caught in a trap when her father arrives. Cooper gets Jacques Renault to reveal the details of Laura's last night in the cabin. Deputy Andy saves Truman's life and apprehends Renault.",
                            EpisodeNumber = 8,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E8.jpg",
                            ImdbRating = 9.0,
                            ReleaseDate = new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 1,
                            Title = "The Last Evening"
                        },
                        new
                        {
                            ID = 9,
                            Description = "A wounded Agent Cooper has a vision of a giant who gives him several clues about the murder of Laura Palmer. Shelly and Pete recover from the mill fire, but Josie and Catherine are missing.",
                            EpisodeNumber = 1,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E1.jpg",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(1990, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "May the Giant Be with You"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Albert determines that neither Leo nor Jacques killed Laura, but he is unable to find any leads into who shot Cooper. Cooper says they must find the third man, who he believes to be Bob, the gray-haired man.",
                            EpisodeNumber = 2,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E2.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(1990, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Coma"
                        },
                        new
                        {
                            ID = 11,
                            Description = "Ronette is attacked in her hospital bed by an unseen person. Jean Renault, brother of Jacques and Bernard, plans to blackmail Ben Horne for the release of Audrey. Donna meets with Harold Smith, a shut-in who had befriended Laura.",
                            EpisodeNumber = 3,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E3.jpg",
                            ImdbRating = 8.0999999999999996,
                            ReleaseDate = new DateTime(1990, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "The Man Behind the Glass"
                        },
                        new
                        {
                            ID = 12,
                            Description = "Leland confesses to killing Jacques Renault. Andy wants to take a new sperm count test. Rumor spreads that a food critic is coming to Twin Peaks. Jean asks Ben to set a trap for Cooper in exchange for Audrey's life.",
                            EpisodeNumber = 4,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E4.jpg",
                            ImdbRating = 8.0,
                            ReleaseDate = new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Laura's Secret Diary"
                        },
                        new
                        {
                            ID = 13,
                            Description = "Cooper remembers the message under his bed. Shelly and Bobby begin Leo's home care. Sternwood hears pretrial motions and declares Leo not fit for trial. Nadine comes home, still thinking she's in high school.",
                            EpisodeNumber = 5,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E5.jpg",
                            ImdbRating = 8.3000000000000007,
                            ReleaseDate = new DateTime(1990, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "The Orchid's Curse"
                        },
                        new
                        {
                            ID = 14,
                            Description = "James saves the girls from a tormented Harold. Cooper brings Audrey home. Bobby and Shelly learn that their insurance plans have backfired. Donna tries to convince Truman that Harold Smith has Laura's secret diary. ",
                            EpisodeNumber = 6,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E6.jpg",
                            ImdbRating = 8.4000000000000004,
                            ReleaseDate = new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Demons"
                        },
                        new
                        {
                            ID = 15,
                            Description = "Cooper and the One-Armed Man inspect guests at the Great Northern. Hawk finds Harold Smith dead - with a mysterious suicide note and the diary torn to shreds. Leo speaks to Bobby about 'new shoes'. ",
                            EpisodeNumber = 7,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E7.jpg",
                            ImdbRating = 9.4000000000000004,
                            ReleaseDate = new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Lonely Souls"
                        },
                        new
                        {
                            ID = 16,
                            Description = "Donna and James wonder why Maddy left so suddenly. Norma's mother arrives with the news that she's married a new man, Ernie Niles. Cooper tells Leland they arrested Ben Horne for Laura's murder. ",
                            EpisodeNumber = 8,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E8.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(1990, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Drive with a Dead Girl"
                        },
                        new
                        {
                            ID = 17,
                            Description = "Albert returns to examine Maddy. Cooper asks for 24 hours to finish his case. James and Donna reaffirm their love. Andy accidentally leads Donna and Cooper back to Mrs. Tremond's house.",
                            EpisodeNumber = 9,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E9.jpg",
                            ImdbRating = 9.3000000000000007,
                            ReleaseDate = new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Arbitrary Law"
                        },
                        new
                        {
                            ID = 18,
                            Description = "Leland is laid to rest and Sarah Palmer tries to accept all that has happened to her family. Dr. Jacoby returns from Hawaii. Cooper prepares to leave Twin Peaks. Mayor Milford objects to his brother's engagement to a younger woman.",
                            EpisodeNumber = 10,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E10.jpg",
                            ImdbRating = 7.7000000000000002,
                            ReleaseDate = new DateTime(1990, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Dispute Between Brothers"
                        },
                        new
                        {
                            ID = 19,
                            Description = "Mrs. Briggs talks about her husband's disappearance into the woods. Nadine is put on the wrestling team, where she falls for Mike Nelson. James is hired by the mysterious, wealthy Evelyn Marsh. Dick takes on an orphan, Little Nicky.",
                            EpisodeNumber = 11,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E11.jpg",
                            ImdbRating = 7.2999999999999998,
                            ReleaseDate = new DateTime(1990, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Masked Ball"
                        },
                        new
                        {
                            ID = 20,
                            Description = "Ben takes Bobby under his wing in a hope to destroy Hank and Jean. However, Ben's mental state is starting to crack. Cooper starts to look at buying real estate. Major Briggs's supervisor reveals that Briggs was studying the woods..",
                            EpisodeNumber = 12,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E12.jpg",
                            ImdbRating = 7.2999999999999998,
                            ReleaseDate = new DateTime(1991, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "The Black Widow"
                        },
                        new
                        {
                            ID = 21,
                            Description = "Major Briggs has no memory of the place he was taken, but now has an odd tattoo on his neck. Andy and Dick break into Little Nicky's files. Mike and Nadine begin an affair. Evelyn asks James to kill her husband.",
                            EpisodeNumber = 13,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E13.jpg",
                            ImdbRating = 7.5999999999999996,
                            ReleaseDate = new DateTime(1991, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Checkmate"
                        },
                        new
                        {
                            ID = 22,
                            Description = "Windom Earle has taken his first victim in the deadly chess game. Audrey tells Bobby they have to save Ben from his civil war fantasy. Leo awakes and attacks Shelly, but Bobby is able to fend him off.",
                            EpisodeNumber = 14,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E14.jpg",
                            ImdbRating = 7.5,
                            ReleaseDate = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Double Play"
                        },
                        new
                        {
                            ID = 23,
                            Description = "The police look for James in the Marsh murder. Bobby and Shelly tell Truman that Leo escaped; and Bobby reveals that he saw Hank shoot Leo the night the mill burned. Albert returns to Twin Peaks with information on Windom Earle.",
                            EpisodeNumber = 15,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E15.jpg",
                            ImdbRating = 7.0999999999999996,
                            ReleaseDate = new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Slaves and Masters"
                        },
                        new
                        {
                            ID = 24,
                            Description = "Truman puts Hank in prison for the attempted murder of Leo, while Hank points the finger at Josie for the murder of Andrew Packard. Albert reveals that Josie shot Cooper. Ben enlists the help of John Justice Wheeler.",
                            EpisodeNumber = 16,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E16.jpg",
                            ImdbRating = 7.7000000000000002,
                            ReleaseDate = new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "The Condemned Woman"
                        },
                        new
                        {
                            ID = 25,
                            Description = "Harry sinks into a deep depression after Josie's death. Josie's body holds more questions than answers. Norma's troubled sister, Annie, arrives in Twin Peaks. Wheeler and Audrey hit it off. Cooper's stalemate angers Earle.",
                            EpisodeNumber = 17,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E17.jpg",
                            ImdbRating = 7.2999999999999998,
                            ReleaseDate = new DateTime(1991, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Wounds and Scars"
                        },
                        new
                        {
                            ID = 26,
                            Description = "Harry is attacked by Jones in his sleep. Audrey and Wheeler begin a relationship. Gordon Cole returns with a report that Windom Earle worked with Major Briggs on Project Bluebook. Cole reinstates Cooper in the FBI.",
                            EpisodeNumber = 18,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E18.jpg",
                            ImdbRating = 7.9000000000000004,
                            ReleaseDate = new DateTime(1991, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "On the Wings of Love"
                        },
                        new
                        {
                            ID = 27,
                            Description = "Cooper and company find the mysterious petroglyph. Windom Earle befriends a rock 'n' roll youth, and tells him tales of places called the White and Black Lodge. Pete helps Catherine open the first puzzle box.",
                            EpisodeNumber = 19,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E19.jpg",
                            ImdbRating = 7.7999999999999998,
                            ReleaseDate = new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Variations and Relations"
                        },
                        new
                        {
                            ID = 28,
                            Description = "Bobby and Shelly reaffirm their love. Cooper calls Shelly, Donna and Audrey together to warn them about Earle. Briggs shows Cooper a tape of Windom Earle making a report on his quest for the Black Lodge.",
                            EpisodeNumber = 20,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E20.jpg",
                            ImdbRating = 8.0999999999999996,
                            ReleaseDate = new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "The Path to the Black Lodge"
                        },
                        new
                        {
                            ID = 29,
                            Description = "Windom Earle sets his sights on the Miss Twin Peaks contest. Lucy chooses a father for her baby. Leo is punished when he frees Major Briggs. Cooper unlocks the key to entering the Black Lodge. Annie and Dale make a commitment.",
                            EpisodeNumber = 21,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E21.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Miss Twin Peaks"
                        },
                        new
                        {
                            ID = 30,
                            Description = "Agent Cooper follows Windom Earle and Annie into the depths of the Black Lodge. Big Ed and Norma get a shock when Nadine suffers head trauma. Andrew and Pete unlock Eckhardt's final box and Audrey stages an act of civil disobedience.",
                            EpisodeNumber = 22,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E22.jpg",
                            ImdbRating = 9.3000000000000007,
                            ReleaseDate = new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 2,
                            Title = "Beyond Life and Death"
                        },
                        new
                        {
                            ID = 31,
                            Description = "My log has a message for you.",
                            EpisodeNumber = 1,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E1.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 1"
                        },
                        new
                        {
                            ID = 32,
                            Description = "The stars turn and a time presents itself.",
                            EpisodeNumber = 2,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E2.jpg",
                            ImdbRating = 8.5999999999999996,
                            ReleaseDate = new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 2"
                        },
                        new
                        {
                            ID = 33,
                            Description = "Call for help.",
                            EpisodeNumber = 3,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E3.jpg",
                            ImdbRating = 8.4000000000000004,
                            ReleaseDate = new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 3"
                        },
                        new
                        {
                            ID = 34,
                            Description = "...brings back some memories.",
                            EpisodeNumber = 4,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E4.jpg",
                            ImdbRating = 8.5,
                            ReleaseDate = new DateTime(2017, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 4"
                        },
                        new
                        {
                            ID = 35,
                            Description = "Case files.",
                            EpisodeNumber = 5,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E5.jpg",
                            ImdbRating = 8.0,
                            ReleaseDate = new DateTime(2017, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 5"
                        },
                        new
                        {
                            ID = 36,
                            Description = "Don't die.",
                            EpisodeNumber = 6,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E6.jpg",
                            ImdbRating = 8.0,
                            ReleaseDate = new DateTime(2017, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 6"
                        },
                        new
                        {
                            ID = 37,
                            Description = "There's a body all right.",
                            EpisodeNumber = 7,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E7.jpg",
                            ImdbRating = 8.5999999999999996,
                            ReleaseDate = new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 7"
                        },
                        new
                        {
                            ID = 38,
                            Description = "Got a light?",
                            EpisodeNumber = 8,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E8.jpg",
                            ImdbRating = 8.8000000000000007,
                            ReleaseDate = new DateTime(2017, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 8"
                        },
                        new
                        {
                            ID = 39,
                            Description = "This is the chair.",
                            EpisodeNumber = 9,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E9.jpg",
                            ImdbRating = 8.3000000000000007,
                            ReleaseDate = new DateTime(2017, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 9"
                        },
                        new
                        {
                            ID = 40,
                            Description = "Laura is the one.",
                            EpisodeNumber = 10,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E10.jpg",
                            ImdbRating = 8.0,
                            ReleaseDate = new DateTime(2017, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 10"
                        },
                        new
                        {
                            ID = 41,
                            Description = "There's fire where you are going.",
                            EpisodeNumber = 11,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E11.jpg",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(2017, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 11"
                        },
                        new
                        {
                            ID = 42,
                            Description = "Let's rock.",
                            EpisodeNumber = 12,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E12.jpg",
                            ImdbRating = 7.5999999999999996,
                            ReleaseDate = new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 12"
                        },
                        new
                        {
                            ID = 43,
                            Description = "What story is that, Charlie?",
                            EpisodeNumber = 13,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E13.jpg",
                            ImdbRating = 8.3000000000000007,
                            ReleaseDate = new DateTime(2017, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 13"
                        },
                        new
                        {
                            ID = 44,
                            Description = "We are like the dreamer.",
                            EpisodeNumber = 14,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E14.jpg",
                            ImdbRating = 8.9000000000000004,
                            ReleaseDate = new DateTime(2017, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 14"
                        },
                        new
                        {
                            ID = 45,
                            Description = "There's some fear in letting go.",
                            EpisodeNumber = 15,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E15.jpg",
                            ImdbRating = 8.6999999999999993,
                            ReleaseDate = new DateTime(2017, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 15"
                        },
                        new
                        {
                            ID = 46,
                            Description = "No knock, no doorbell.",
                            EpisodeNumber = 16,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E16.jpg",
                            ImdbRating = 9.5,
                            ReleaseDate = new DateTime(2017, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 16"
                        },
                        new
                        {
                            ID = 47,
                            Description = "The past dictates the future.",
                            EpisodeNumber = 17,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E17.jpg",
                            ImdbRating = 9.4000000000000004,
                            ReleaseDate = new DateTime(2017, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 17"
                        },
                        new
                        {
                            ID = 48,
                            Description = "What is your name?",
                            EpisodeNumber = 18,
                            ImagePath = "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E18.jpg",
                            ImdbRating = 8.6999999999999993,
                            ReleaseDate = new DateTime(2017, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SeasonID = 3,
                            Title = "Part 18"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
