using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateNewContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimal_AnimalModel_AnimalId",
                table: "UserAnimal");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimal_Users_UserId",
                table: "UserAnimal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel");

            migrationBuilder.RenameTable(
                name: "UserAnimal",
                newName: "UserAnimals");

            migrationBuilder.RenameTable(
                name: "AnimalModel",
                newName: "AnimalModels");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnimal_AnimalId",
                table: "UserAnimals",
                newName: "IX_UserAnimals_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals",
                columns: new[] { "UserId", "AnimalId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimals_Users_UserId",
                table: "UserAnimals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_AnimalModels_AnimalId",
                table: "UserAnimals");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAnimals_Users_UserId",
                table: "UserAnimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnimals",
                table: "UserAnimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalModels",
                table: "AnimalModels");

            migrationBuilder.RenameTable(
                name: "UserAnimals",
                newName: "UserAnimal");

            migrationBuilder.RenameTable(
                name: "AnimalModels",
                newName: "AnimalModel");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnimals_AnimalId",
                table: "UserAnimal",
                newName: "IX_UserAnimal_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnimal",
                table: "UserAnimal",
                columns: new[] { "UserId", "AnimalId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalModel",
                table: "AnimalModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimal_AnimalModel_AnimalId",
                table: "UserAnimal",
                column: "AnimalId",
                principalTable: "AnimalModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnimal_Users_UserId",
                table: "UserAnimal",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
