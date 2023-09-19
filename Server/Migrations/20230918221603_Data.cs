using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASKProjekt.Server.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Glosor",
                columns: new[] { "Id", "Language1", "Language2" },
                values: new object[,]
                {
                    { 3, "Komma ihåg", "Remember" },
                    { 4, "Idag", "Today" },
                    { 5, "Imorgon", "Tomorrow" },
                    { 6, "Igår", "Yesterday" },
                    { 7, "Springa", "Run" },
                    { 8, "Gå", "Walk" },
                    { 9, "Moln", "Cloud" },
                    { 10, "Sol", "Sun" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Glosor",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
