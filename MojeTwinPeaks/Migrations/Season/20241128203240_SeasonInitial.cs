using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MojeTwinPeaks.Migrations.Season
{
    /// <inheritdoc />
    public partial class SeasonInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Episodes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "Episodes", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(1990, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 22, new DateTime(1990, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 18, new DateTime(2017, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
