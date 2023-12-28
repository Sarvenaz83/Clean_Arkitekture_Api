using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRegisterAndLoginPart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("030b83d6-c6b0-4886-a347-4dc1c2e3aa7b"), "", false, "", "Dog", false, "Dog2", "", 0 },
                    { new Guid("0bb5ca00-7e72-45fa-b990-ca00260adcce"), "", false, "", "Dog", false, "Dog1", "", 0 },
                    { new Guid("30837b20-09ca-4085-a350-0e4f87860279"), "", false, "", "Dog", false, "Dog4", "", 0 },
                    { new Guid("3a3a8aea-1563-465a-aa47-0e5fb85b47d8"), "", false, "", "Bird", false, "Bird2", "", 0 },
                    { new Guid("5ad694f5-6d90-4b7f-92bb-b9b55206e6ab"), "", false, "", "Cat", false, "Cat2", "", 0 },
                    { new Guid("7bb91beb-3c0f-4138-930e-3b3d7acf90bb"), "", false, "", "Bird", false, "Bird3", "", 0 },
                    { new Guid("9aa11e08-b1b5-4053-9e60-28808fb39593"), "", false, "", "Bird", false, "Bird1", "", 0 },
                    { new Guid("a247aca7-45b9-4e9c-849b-198728a50094"), "", false, "", "Bird", false, "Bird4", "", 0 },
                    { new Guid("a4728230-6bcc-4bca-9002-149ed61c00f4"), "", false, "", "Dog", false, "Dog3", "", 0 },
                    { new Guid("b63c75e1-d91f-4b85-b19b-6339333fb319"), "", false, "", "Cat", false, "Cat4", "", 0 },
                    { new Guid("dad978e2-ead6-4928-9974-2a64e8423ee6"), "", false, "", "Cat", false, "Cat1", "", 0 },
                    { new Guid("eb0a850f-4c05-4411-882a-66b13313c37f"), "", false, "", "Cat", false, "Cat3", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("030b83d6-c6b0-4886-a347-4dc1c2e3aa7b"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("0bb5ca00-7e72-45fa-b990-ca00260adcce"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("30837b20-09ca-4085-a350-0e4f87860279"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3a3a8aea-1563-465a-aa47-0e5fb85b47d8"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5ad694f5-6d90-4b7f-92bb-b9b55206e6ab"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("7bb91beb-3c0f-4138-930e-3b3d7acf90bb"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("9aa11e08-b1b5-4053-9e60-28808fb39593"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("a247aca7-45b9-4e9c-849b-198728a50094"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("a4728230-6bcc-4bca-9002-149ed61c00f4"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("b63c75e1-d91f-4b85-b19b-6339333fb319"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("dad978e2-ead6-4928-9974-2a64e8423ee6"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("eb0a850f-4c05-4411-882a-66b13313c37f"));

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
    }
}
