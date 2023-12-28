using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewChangesForLoginAndRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "CanFly", "Color", "Discriminator", "LikesToPlay", "Name", "OwnerUserName", "Weight" },
                values: new object[,]
                {
                    { new Guid("128b44db-6316-41e4-8c12-ab59104e2810"), "", false, "", "Cat", false, "Cat2", "", 0 },
                    { new Guid("378ffe03-b5c6-4f2c-bf2d-224e1f4d48e6"), "", false, "", "Bird", false, "Bird1", "", 0 },
                    { new Guid("3d37beea-16eb-4095-8522-6c28bb6a1844"), "", false, "", "Dog", false, "Dog3", "", 0 },
                    { new Guid("439a847e-b06e-42ed-9cd8-7aab9766a279"), "", false, "", "Cat", false, "Cat4", "", 0 },
                    { new Guid("540d9525-e1a5-4b2b-ac53-827972b251c1"), "", false, "", "Bird", false, "Bird3", "", 0 },
                    { new Guid("57f2819b-2f01-4e1d-bbd0-877bb6da1a69"), "", false, "", "Bird", false, "Bird4", "", 0 },
                    { new Guid("646ee85d-1921-4647-87b6-fd3e51f0e77f"), "", false, "", "Dog", false, "Dog4", "", 0 },
                    { new Guid("8041d935-9f4a-4b0a-9e99-faeeb245c7a4"), "", false, "", "Dog", false, "Dog1", "", 0 },
                    { new Guid("9006e8f5-d3d0-4ea5-93d7-ff3e650388b0"), "", false, "", "Cat", false, "Cat3", "", 0 },
                    { new Guid("b1c5612a-002d-43c0-b2bd-e6f202880e0e"), "", false, "", "Dog", false, "Dog2", "", 0 },
                    { new Guid("ea617490-71e6-4996-8f4c-54105d7cb6aa"), "", false, "", "Bird", false, "Bird2", "", 0 },
                    { new Guid("fbb4d9ab-cb31-4019-b544-5c7c3ade5a3a"), "", false, "", "Cat", false, "Cat1", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("128b44db-6316-41e4-8c12-ab59104e2810"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("378ffe03-b5c6-4f2c-bf2d-224e1f4d48e6"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3d37beea-16eb-4095-8522-6c28bb6a1844"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("439a847e-b06e-42ed-9cd8-7aab9766a279"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("540d9525-e1a5-4b2b-ac53-827972b251c1"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("57f2819b-2f01-4e1d-bbd0-877bb6da1a69"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("646ee85d-1921-4647-87b6-fd3e51f0e77f"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8041d935-9f4a-4b0a-9e99-faeeb245c7a4"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("9006e8f5-d3d0-4ea5-93d7-ff3e650388b0"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("b1c5612a-002d-43c0-b2bd-e6f202880e0e"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("ea617490-71e6-4996-8f4c-54105d7cb6aa"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("fbb4d9ab-cb31-4019-b544-5c7c3ade5a3a"));

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
    }
}
