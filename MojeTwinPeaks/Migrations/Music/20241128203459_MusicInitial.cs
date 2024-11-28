using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MojeTwinPeaks.Migrations.Music
{
    /// <inheritdoc />
    public partial class MusicInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusicTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YouTubeUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicTable", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "MusicTable",
                columns: new[] { "ID", "Artist", "ImagePath", "Name", "YouTubeUrl" },
                values: new object[,]
                {
                    { 1, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/AudreysDance.jpg ", "Audrey's Dance", "https://youtu.be/nITuHzF4ryk" },
                    { 2, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/DanceOfTheDreamMan.jpg ", "Dance Of The Dream Man", "https://youtu.be/kBn_lQBh9JA" },
                    { 3, "Julee Cruise", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/Falling.jpg ", "Falling", "https://youtu.be/KkR6Jd0Agi4" },
                    { 4, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/FreshlySqueezed.jpg ", "Freshly Squeezed", "https://youtu.be/bc-Prdyp9LY " },
                    { 5, "Julee Cruise", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/IntoTheNight.jpg ", "Into The Night", "https://youtu.be/euq0sKwbDTg" },
                    { 6, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/LauraPalmersTheme.jpg ", "Laura Palmers Theme", "https://youtu.be/woUt7wPe8Ow" },
                    { 7, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/LoveTheme.jpg ", "Love Theme", "https://youtu.be/JwHwyejd-vk" },
                    { 8, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TheBookhouseBoys.jpg ", "The Bookhouse Boys", "https://youtu.be/rQrVeoiebWs" },
                    { 9, "Julee Cruise", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TheNightingale.jpg ", "The Nightingale", "https://youtu.be/BzImHGz4R0M" },
                    { 10, "Angelo Badalamenti", "https://twinpeaksimgstorage.blob.core.windows.net/musicimages/TwinPeaksTheme.jpg ", "Twin Peaks Theme", "https://youtu.be/nCn3LYqCnrk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicTable");
        }
    }
}
