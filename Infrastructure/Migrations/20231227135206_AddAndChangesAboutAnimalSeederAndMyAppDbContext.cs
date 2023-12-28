using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAndChangesAboutAnimalSeederAndMyAppDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "CanFly", "Color", "Discriminator", "LikesToPlay", "Name", "OwnerUserName", "Weight" },
                values: new object[,]
                {
                    { new Guid("200bc4c5-5df6-4e69-8dfc-9a489588014d"), "", false, "", "Bird", false, "Bird3", "", 0 },
                    { new Guid("29f74e5d-b912-4adf-8901-d9be61ea5a58"), "", false, "", "Cat", false, "Cat3", "", 0 },
                    { new Guid("2e7c0922-c41b-4852-a801-71d3ff28dde4"), "", false, "", "Cat", false, "Cat2", "", 0 },
                    { new Guid("3ea5072b-b346-4cf9-b6fc-ae9bcacd26c8"), "", false, "", "Dog", false, "Dog2", "", 0 },
                    { new Guid("4bd48eee-40c0-4fe6-8f2f-a144680affcc"), "", false, "", "Dog", false, "Dog4", "", 0 },
                    { new Guid("4ed57e2f-07d9-402a-abf3-565153dbc239"), "", false, "", "Cat", false, "Cat4", "", 0 },
                    { new Guid("67281710-0808-4a12-beeb-11c8427c8d76"), "", false, "", "Cat", false, "Cat1", "", 0 },
                    { new Guid("8dd97c73-d77c-4e4b-9c16-88e77c2cfea4"), "", false, "", "Bird", false, "Bird1", "", 0 },
                    { new Guid("9e411c4d-716f-4393-9d29-681c1b5abd43"), "", false, "", "Bird", false, "Bird2", "", 0 },
                    { new Guid("a81f2304-18a6-4bbd-b5d8-175cf85038f1"), "", false, "", "Dog", false, "Dog1", "", 0 },
                    { new Guid("d2dbefea-88ce-4132-b713-1ba54d28fa98"), "", false, "", "Bird", false, "Bird4", "", 0 },
                    { new Guid("f3efc79b-4b8f-4a82-bcd1-7efcf16f8e02"), "", false, "", "Dog", false, "Dog3", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("200bc4c5-5df6-4e69-8dfc-9a489588014d"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("29f74e5d-b912-4adf-8901-d9be61ea5a58"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("2e7c0922-c41b-4852-a801-71d3ff28dde4"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3ea5072b-b346-4cf9-b6fc-ae9bcacd26c8"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("4bd48eee-40c0-4fe6-8f2f-a144680affcc"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("4ed57e2f-07d9-402a-abf3-565153dbc239"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("67281710-0808-4a12-beeb-11c8427c8d76"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8dd97c73-d77c-4e4b-9c16-88e77c2cfea4"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("9e411c4d-716f-4393-9d29-681c1b5abd43"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("a81f2304-18a6-4bbd-b5d8-175cf85038f1"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("d2dbefea-88ce-4132-b713-1ba54d28fa98"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("f3efc79b-4b8f-4a82-bcd1-7efcf16f8e02"));
        }
    }
}
