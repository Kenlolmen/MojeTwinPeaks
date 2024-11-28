using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MojeTwinPeaks.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonID = table.Column<int>(type: "int", nullable: false),
                    EpisodeNumber = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "ID", "Description", "EpisodeNumber", "ImagePath", "ImdbRating", "ReleaseDate", "SeasonID", "Title" },
                values: new object[,]
                {
                    { 1, "The small northwest town of Twin Peaks, Washington is shaken up when the body of the Homecoming Queen, Laura Palmer, is discovered washed up on a riverbank, wrapped in plastic.", 1, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E1.jpg", 8.9000000000000004, new DateTime(1990, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Northwest Passage" },
                    { 2, "Agent Cooper enjoys the comforts of the Great Northern Hotel. Bobby Briggs and Mike Nelson are released from jail. Doctor Hayward hands over the autopsy report on Laura Palmer.", 2, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E2.jpg", 8.1999999999999993, new DateTime(1990, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Traces to Nowhere" },
                    { 3, "Ben Horne's brother, Jerry, arrives in Twin Peaks; together they travel to One Eyed Jack's and meet with the madam, Blackie O'Reilly. Audrey leaves a clue for Cooper. Deputy Hawk finds a bloody towel near the crime scene.", 3, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E3.jpg", 8.9000000000000004, new DateTime(1990, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Zen, or the Skill to Catch a Killer" },
                    { 4, "Cooper meets with Audrey, who confesses to leaving him the note about One Eyed Jack's. Cooper tells Truman he can't remember who the killer was in his dream, but insists the dream is a code to solving the crime.", 4, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E4.jpg", 8.1999999999999993, new DateTime(1990, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Rest in Pain" },
                    { 5, "Cooper questions Dr. Jacoby, who suspects Leo Johnson is the killer. Gordon Cole, Cooper's supervisor, calls in with Albert's report.Josie Packard spies on Ben Horne and Catherine Martell. Hawk tracks down the One-Armed Man.", 5, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E5.jpg", 8.0999999999999996, new DateTime(1990, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "The One-Armed Man" },
                    { 6, "Cooper and company have tea with the Log Lady, who tells them there was a third man following after Leo and Jacques the night Laura died. At Jacques Renault's cabin Cooper, Hawk, and Truman find Waldo the bird.", 6, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E6.jpg", 8.4000000000000004, new DateTime(1990, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cooper's Dreams" },
                    { 7, "Audrey cons her way into working at the perfume counter where Laura worked and discovers that it's being used as a recruitment post for One Eyed Jack's. James, Donna and Maddy plan to lure Jacoby away from his office.", 7, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E7.jpg", 8.5, new DateTime(1990, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Realization Time" },
                    { 8, "Audrey is hired at One Eyed Jack's, but is caught in a trap when her father arrives. Cooper gets Jacques Renault to reveal the details of Laura's last night in the cabin. Deputy Andy saves Truman's life and apprehends Renault.", 8, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S1E8.jpg", 9.0, new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "The Last Evening" },
                    { 9, "A wounded Agent Cooper has a vision of a giant who gives him several clues about the murder of Laura Palmer. Shelly and Pete recover from the mill fire, but Josie and Catherine are missing.", 1, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E1.jpg", 8.9000000000000004, new DateTime(1990, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "May the Giant Be with You" },
                    { 10, "Albert determines that neither Leo nor Jacques killed Laura, but he is unable to find any leads into who shot Cooper. Cooper says they must find the third man, who he believes to be Bob, the gray-haired man.", 2, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E2.jpg", 8.5, new DateTime(1990, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Coma" },
                    { 11, "Ronette is attacked in her hospital bed by an unseen person. Jean Renault, brother of Jacques and Bernard, plans to blackmail Ben Horne for the release of Audrey. Donna meets with Harold Smith, a shut-in who had befriended Laura.", 3, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E3.jpg", 8.0999999999999996, new DateTime(1990, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Man Behind the Glass" },
                    { 12, "Leland confesses to killing Jacques Renault. Andy wants to take a new sperm count test. Rumor spreads that a food critic is coming to Twin Peaks. Jean asks Ben to set a trap for Cooper in exchange for Audrey's life.", 4, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E4.jpg", 8.0, new DateTime(1990, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Laura's Secret Diary" },
                    { 13, "Cooper remembers the message under his bed. Shelly and Bobby begin Leo's home care. Sternwood hears pretrial motions and declares Leo not fit for trial. Nadine comes home, still thinking she's in high school.", 5, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E5.jpg", 8.3000000000000007, new DateTime(1990, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Orchid's Curse" },
                    { 14, "James saves the girls from a tormented Harold. Cooper brings Audrey home. Bobby and Shelly learn that their insurance plans have backfired. Donna tries to convince Truman that Harold Smith has Laura's secret diary. ", 6, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E6.jpg", 8.4000000000000004, new DateTime(1990, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Demons" },
                    { 15, "Cooper and the One-Armed Man inspect guests at the Great Northern. Hawk finds Harold Smith dead - with a mysterious suicide note and the diary torn to shreds. Leo speaks to Bobby about 'new shoes'. ", 7, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E7.jpg", 9.4000000000000004, new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Lonely Souls" },
                    { 16, "Donna and James wonder why Maddy left so suddenly. Norma's mother arrives with the news that she's married a new man, Ernie Niles. Cooper tells Leland they arrested Ben Horne for Laura's murder. ", 8, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E8.jpg", 8.5, new DateTime(1990, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Drive with a Dead Girl" },
                    { 17, "Albert returns to examine Maddy. Cooper asks for 24 hours to finish his case. James and Donna reaffirm their love. Andy accidentally leads Donna and Cooper back to Mrs. Tremond's house.", 9, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E9.jpg", 9.3000000000000007, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Arbitrary Law" },
                    { 18, "Leland is laid to rest and Sarah Palmer tries to accept all that has happened to her family. Dr. Jacoby returns from Hawaii. Cooper prepares to leave Twin Peaks. Mayor Milford objects to his brother's engagement to a younger woman.", 10, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E10.jpg", 7.7000000000000002, new DateTime(1990, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Dispute Between Brothers" },
                    { 19, "Mrs. Briggs talks about her husband's disappearance into the woods. Nadine is put on the wrestling team, where she falls for Mike Nelson. James is hired by the mysterious, wealthy Evelyn Marsh. Dick takes on an orphan, Little Nicky.", 11, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E11.jpg", 7.2999999999999998, new DateTime(1990, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Masked Ball" },
                    { 20, "Ben takes Bobby under his wing in a hope to destroy Hank and Jean. However, Ben's mental state is starting to crack. Cooper starts to look at buying real estate. Major Briggs's supervisor reveals that Briggs was studying the woods..", 12, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E12.jpg", 7.2999999999999998, new DateTime(1991, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Black Widow" },
                    { 21, "Major Briggs has no memory of the place he was taken, but now has an odd tattoo on his neck. Andy and Dick break into Little Nicky's files. Mike and Nadine begin an affair. Evelyn asks James to kill her husband.", 13, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E13.jpg", 7.5999999999999996, new DateTime(1991, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Checkmate" },
                    { 22, "Windom Earle has taken his first victim in the deadly chess game. Audrey tells Bobby they have to save Ben from his civil war fantasy. Leo awakes and attacks Shelly, but Bobby is able to fend him off.", 14, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E14.jpg", 7.5, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Double Play" },
                    { 23, "The police look for James in the Marsh murder. Bobby and Shelly tell Truman that Leo escaped; and Bobby reveals that he saw Hank shoot Leo the night the mill burned. Albert returns to Twin Peaks with information on Windom Earle.", 15, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E15.jpg", 7.0999999999999996, new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Slaves and Masters" },
                    { 24, "Truman puts Hank in prison for the attempted murder of Leo, while Hank points the finger at Josie for the murder of Andrew Packard. Albert reveals that Josie shot Cooper. Ben enlists the help of John Justice Wheeler.", 16, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E16.jpg", 7.7000000000000002, new DateTime(1991, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Condemned Woman" },
                    { 25, "Harry sinks into a deep depression after Josie's death. Josie's body holds more questions than answers. Norma's troubled sister, Annie, arrives in Twin Peaks. Wheeler and Audrey hit it off. Cooper's stalemate angers Earle.", 17, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E17.jpg", 7.2999999999999998, new DateTime(1991, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Wounds and Scars" },
                    { 26, "Harry is attacked by Jones in his sleep. Audrey and Wheeler begin a relationship. Gordon Cole returns with a report that Windom Earle worked with Major Briggs on Project Bluebook. Cole reinstates Cooper in the FBI.", 18, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E18.jpg", 7.9000000000000004, new DateTime(1991, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "On the Wings of Love" },
                    { 27, "Cooper and company find the mysterious petroglyph. Windom Earle befriends a rock 'n' roll youth, and tells him tales of places called the White and Black Lodge. Pete helps Catherine open the first puzzle box.", 19, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E19.jpg", 7.7999999999999998, new DateTime(1991, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Variations and Relations" },
                    { 28, "Bobby and Shelly reaffirm their love. Cooper calls Shelly, Donna and Audrey together to warn them about Earle. Briggs shows Cooper a tape of Windom Earle making a report on his quest for the Black Lodge.", 20, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E20.jpg", 8.0999999999999996, new DateTime(1991, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "The Path to the Black Lodge" },
                    { 29, "Windom Earle sets his sights on the Miss Twin Peaks contest. Lucy chooses a father for her baby. Leo is punished when he frees Major Briggs. Cooper unlocks the key to entering the Black Lodge. Annie and Dale make a commitment.", 21, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E21.jpg", 8.5, new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Miss Twin Peaks" },
                    { 30, "Agent Cooper follows Windom Earle and Annie into the depths of the Black Lodge. Big Ed and Norma get a shock when Nadine suffers head trauma. Andrew and Pete unlock Eckhardt's final box and Audrey stages an act of civil disobedience.", 22, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S2E22.jpg", 9.3000000000000007, new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Beyond Life and Death" },
                    { 31, "My log has a message for you.", 1, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E1.jpg", 8.5, new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 1" },
                    { 32, "The stars turn and a time presents itself.", 2, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E2.jpg", 8.5999999999999996, new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 2" },
                    { 33, "Call for help.", 3, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E3.jpg", 8.4000000000000004, new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 3" },
                    { 34, "...brings back some memories.", 4, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E4.jpg", 8.5, new DateTime(2017, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 4" },
                    { 35, "Case files.", 5, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E5.jpg", 8.0, new DateTime(2017, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 5" },
                    { 36, "Don't die.", 6, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E6.jpg", 8.0, new DateTime(2017, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 6" },
                    { 37, "There's a body all right.", 7, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E7.jpg", 8.5999999999999996, new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 7" },
                    { 38, "Got a light?", 8, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E8.jpg", 8.8000000000000007, new DateTime(2017, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 8" },
                    { 39, "This is the chair.", 9, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E9.jpg", 8.3000000000000007, new DateTime(2017, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 9" },
                    { 40, "Laura is the one.", 10, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E10.jpg", 8.0, new DateTime(2017, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 10" },
                    { 41, "There's fire where you are going.", 11, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E11.jpg", 8.9000000000000004, new DateTime(2017, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 11" },
                    { 42, "Let's rock.", 12, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E12.jpg", 7.5999999999999996, new DateTime(2017, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 12" },
                    { 43, "What story is that, Charlie?", 13, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E13.jpg", 8.3000000000000007, new DateTime(2017, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 13" },
                    { 44, "We are like the dreamer.", 14, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E14.jpg", 8.9000000000000004, new DateTime(2017, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 14" },
                    { 45, "There's some fear in letting go.", 15, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E15.jpg", 8.6999999999999993, new DateTime(2017, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 15" },
                    { 46, "No knock, no doorbell.", 16, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E16.jpg", 9.5, new DateTime(2017, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 16" },
                    { 47, "The past dictates the future.", 17, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E17.jpg", 9.4000000000000004, new DateTime(2017, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 17" },
                    { 48, "What is your name?", 18, "https://twinpeaksimgstorage.blob.core.windows.net/episodesimages/S3E18.jpg", 8.6999999999999993, new DateTime(2017, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Part 18" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");
        }
    }
}
