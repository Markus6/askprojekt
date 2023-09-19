using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASKProjekt.Server.Migrations
{
    /// <inheritdoc />
    public partial class Glosor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Glosa",
                table: "Glosa");

            migrationBuilder.RenameTable(
                name: "Glosa",
                newName: "Glosor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Glosor",
                table: "Glosor",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Glosor",
                table: "Glosor");

            migrationBuilder.RenameTable(
                name: "Glosor",
                newName: "Glosa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Glosa",
                table: "Glosa",
                column: "Id");
        }
    }
}
