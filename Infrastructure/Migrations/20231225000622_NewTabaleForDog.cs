using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewTabaleForDog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_AnimalModels_AnimalId",
                table: "UserAnimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalModels",
                table: "AnimalModels");

            migrationBuilder.RenameTable(
                name: "AnimalModels",
                newName: "AnimalModel");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimalModel",
                newName: "DogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel",
                column: "DogId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimals_AnimalModel_AnimalId",
                table: "UserAnimals",
                column: "AnimalId",
                principalTable: "AnimalModel",
                principalColumn: "DogId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_AnimalModel_AnimalId",
                table: "UserAnimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel");

            migrationBuilder.RenameTable(
                name: "AnimalModel",
                newName: "AnimalModels");

            migrationBuilder.RenameColumn(
                name: "DogId",
                table: "AnimalModels",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalModels",
                table: "AnimalModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimals_AnimalModels_AnimalId",
                table: "UserAnimals",
                column: "AnimalId",
                principalTable: "AnimalModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
