using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASKProjekt.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Glosa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glosa", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Glosa",
                columns: new[] { "Id", "Language1", "Language2" },
                values: new object[,]
                {
                    { 1, "Hej", "Hello" },
                    { 2, "Hejdå", "Goodbye" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Glosa");
        }
    }
}
