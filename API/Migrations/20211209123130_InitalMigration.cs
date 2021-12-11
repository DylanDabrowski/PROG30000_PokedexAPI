using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon");

            migrationBuilder.RenameTable(
                name: "Pokemon",
                newName: "Pokemons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.RenameTable(
                name: "Pokemons",
                newName: "Pokemon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon",
                column: "Id");
        }
    }
}
