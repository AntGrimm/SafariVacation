using Microsoft.EntityFrameworkCore.Migrations;

namespace SafariVacation.Migrations
{
    public partial class ChangedNameToSeenAnimalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeenAnimals",
                table: "SeenAnimals");

            migrationBuilder.RenameTable(
                name: "SeenAnimals",
                newName: "SeenAnimal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeenAnimal",
                table: "SeenAnimal",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeenAnimal",
                table: "SeenAnimal");

            migrationBuilder.RenameTable(
                name: "SeenAnimal",
                newName: "SeenAnimals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeenAnimals",
                table: "SeenAnimals",
                column: "Id");
        }
    }
}
