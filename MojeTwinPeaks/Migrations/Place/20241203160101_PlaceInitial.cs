using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MojeTwinPeaks.Migrations.Place
{
    /// <inheritdoc />
    public partial class PlaceInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "ID", "Description", "ImagePath", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "The Black Lodge in Twin Peaks is a mysterious and otherworldly dimension steeped in surrealism and menace. It is marked by red draped curtains that stretch endlessly, black-and-white chevron-patterned floors that create a disorienting effect, and sparse, minimalist furniture that adds to its dreamlike quality. The Lodge is inhabited by enigmatic beings, including the cryptic Man from Another Place, who speaks in reverse, and the sinister doppelgängers of various characters. It serves as a place of great metaphysical significance, representing a realm of chaos and darkness, contrasting with the White Lodge's supposed purity. Time and space are distorted within the Black Lodge, creating an unsettling atmosphere where reality blurs with nightmares.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Black Lodge.jpg", "Black Lodge", 0 },
                    { 2, "The Convenience Store in Twin Peaks is a disturbing and enigmatic location that exists on the boundary between the physical and metaphysical. First mentioned as a meeting place for supernatural entities, it later appears as a shadowy, decaying structure filled with flickering lights and a palpable sense of unease. The store seems abandoned but hosts the gatherings of malevolent beings such as the woodsmen and other Lodge-related figures. The phrase \"above a convenience store\" suggests that it serves as a gateway or a liminal space where the realms of reality and the Black Lodge intersect. The store’s existence challenges the nature of physical locations, implying it is more a state of being than a tangible place, adding to its eerie mystique.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Convenience store.jpg", "Convenience store", 0 },
                    { 3, "Las Vegas in Twin Peaks is depicted as a glitzy, chaotic, and morally ambiguous urban landscape that contrasts sharply with the quiet, mysterious town of Twin Peaks. The city is central to the storyline involving Dougie Jones, a manufactured tulpa who lives a suburban life with his wife Janey-E and son Sonny Jim. While outwardly a place of wealth and opportunity, Las Vegas hides a darker underbelly of crime, corruption, and exploitation, as seen in the dealings of characters like the Mitchum Brothers and the various criminal elements tied to Dougie's insurance work. Its bright, artificial allure serves as a jarring backdrop for Dougie’s surreal journey, blending comedy, danger, and supernatural intrigue into one of the show's most unique subplots.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Las Vegas.jpg", "Las Vegas", 1 },
                    { 4, "One Eyed Jacks is a luxurious yet morally corrupt casino and brothel located just across the Canadian border. Its lush red decor, opulent gambling halls, and secretive private rooms create an atmosphere of seduction and danger. The establishment is owned by shady businessman Ben Horne and serves as a front for illegal activities, including prostitution and drug trafficking. Many of the show’s darker and more scandalous plotlines converge at One Eyed Jacks, such as the exploitation of young women and the web of deceit surrounding Horne’s business dealings. Despite its glamour, the casino is a symbol of the rot beneath the surface of Twin Peaks’ idyllic veneer.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/One Eyed Jacks.jpg", "One Eyed Jacks", 2 },
                    { 5, "The Palmer House is one of the most iconic locations in Twin Peaks, representing both domestic normalcy and unimaginable horror. Situated in a quiet suburban neighborhood, the house is home to the Palmer family—Leland, Sarah, and Laura. While it appears to be an ordinary family residence, it is haunted by the dark secrets of its occupants. The house becomes a site of intense emotional and supernatural activity, from Laura’s suffering to Leland’s possession by the malevolent entity BOB. Its interiors, including the living room and staircase, are settings for some of the series’ most harrowing and memorable scenes. Over time, the house itself feels imbued with an ominous presence, as though it has absorbed the traumas and evils within.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/PalmersHouse.jpg", "Palmers House", 4 },
                    { 6, "The Red Room, located within the Black Lodge, is one of the most visually and thematically striking locations in Twin Peaks. Characterized by its blood-red curtains, black-and-white chevron floor, and sparse, mid-century modern furnishings, it exudes a dreamlike and otherworldly atmosphere. Time and space are distorted here, and characters who enter experience surreal and often terrifying encounters. The room is home to cryptic figures like The Man from Another Place and doppelgängers, who communicate in riddles and speak backward, adding to the unsettling ambiance. The Red Room serves as both a place of revelation and torment, embodying the duality and mystery central to the series.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Red room.jpg", "Red room", 0 },
                    { 7, "The Roadhouse, also known as The Bang Bang Bar, is a smoky, neon-lit bar that serves as a central social hub for the residents of Twin Peaks. It features live performances by hauntingly beautiful artists, making it a space where the town’s underlying melancholy comes to the forefront. While it initially seems like a simple bar, it becomes a setting for many significant moments, from dramatic confrontations to cryptic dream sequences. The Roadhouse often feels like a liminal space where reality blurs, and its patrons—young lovers, schemers, and lost souls—gather under its dim lights. It captures the soul of the town, where hope and despair intermingle in a haze of music and secrets.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Roadhouse.jpg", "Roadhouse", 7 },
                    { 8, "The Dutchman’s Lodge is a spectral, ghostly hotel that serves as a gathering place for malevolent Lodge entities, including Phillip Jeffries. Shrouded in mystery and almost impossible to locate without supernatural guidance, the lodge appears as a decayed, otherworldly structure in a state of perpetual flux. It exists outside conventional time and space, adding to its eerie and disorienting nature. The lodge’s shadowy corridors and otherworldly residents evoke dread, and it is a crucial site in the complex narrative of evil forces at play in the Twin Peaks universe.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/The Dutchman's Lodge.jpg", "The Dutchman's Lodge", 0 },
                    { 9, "Twin Peaks High School is a key location in the early episodes of the series, representing a seemingly innocent slice of small-town life. The school is where Laura Palmer's death sends shockwaves through the student body, with scenes of students mourning her loss providing some of the show’s most poignant moments. It is also the site of pivotal interactions between characters such as Donna Hayward, James Hurley, and Audrey Horne. Beneath the surface, the school reflects the duality of the town, with its outward wholesomeness masking the darker truths of its students and faculty", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Twin Peaks High School.jpg", "Twin Peaks High School", 8 },
                    { 10, "The Twin Peaks Sheriff’s Department is the heart of law enforcement in the town and a hub of activity throughout the series. Led by the steadfast Sheriff Harry S. Truman and later his brother Frank, the department works alongside FBI Special Agent Dale Cooper to unravel the mysteries surrounding Laura Palmer’s death. With its rustic, wood-paneled interiors and down-to-earth staff like Deputy Andy and receptionist Lucy, the department reflects the quirky yet determined spirit of Twin Peaks. It is a place of camaraderie, investigation, and occasional humor, where the fight against the town’s darkness takes shape.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/Twin Peaks Sheriff's Department.jpg", "Twin Peaks Sheriff's Department", 9 },
                    { 11, "The White Lodge is a mystical realm that serves as a counterpart to the Black Lodge, representing a force of good and enlightenment. Mentioned in legends by the Log Lady and others, it is described as a place of pure spirit and wisdom. While its physical appearance is never fully revealed, it is often associated with serene, ethereal imagery. The White Lodge embodies the themes of duality and balance in the Twin Peaks mythos, standing in opposition to the chaos and malevolence of the Black Lodge. It serves as a beacon of hope and a reminder of the possibility of redemption amidst darkness.", "https://twinpeaksimgstorage.blob.core.windows.net/placeimages/White Lodge.jpg", "White Lodge", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
