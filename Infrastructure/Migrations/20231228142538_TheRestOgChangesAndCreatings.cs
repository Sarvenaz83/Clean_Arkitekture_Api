using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TheRestOgChangesAndCreatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1555d866-1afa-45a2-a274-b30f684d9006"), "", false, "", "Dog", false, "Dog2", "", 0 },
                    { new Guid("2f046260-fc5e-4944-b156-730d13d52057"), "", false, "", "Dog", false, "Dog4", "", 0 },
                    { new Guid("3a36b97f-77aa-4d8e-9d36-291333549f54"), "", false, "", "Bird", false, "Bird2", "", 0 },
                    { new Guid("3b42c83f-cb2a-4dee-9842-9ef9fa4fdabc"), "", false, "", "Bird", false, "Bird1", "", 0 },
                    { new Guid("4a13a5c5-cd7d-4e34-b279-ea589005a5be"), "", false, "", "Bird", false, "Bird4", "", 0 },
                    { new Guid("4d6b6906-38d2-46c2-98fb-f38f51d2d181"), "", false, "", "Cat", false, "Cat2", "", 0 },
                    { new Guid("5458be4e-ad9d-48e2-981d-bc48e3a2dadc"), "", false, "", "Dog", false, "Dog1", "", 0 },
                    { new Guid("6c489eef-b0c2-4fb5-bbc2-f4b99b7b8913"), "", false, "", "Cat", false, "Cat4", "", 0 },
                    { new Guid("8043c9f5-cae6-42f3-a7a4-3f10065ef84d"), "", false, "", "Cat", false, "Cat3", "", 0 },
                    { new Guid("976e4f1f-7c5f-4996-8ec6-53477c9979dd"), "", false, "", "Cat", false, "Cat1", "", 0 },
                    { new Guid("b62a91e7-d729-4ead-b9d6-77e24a4d3f94"), "", false, "", "Dog", false, "Dog3", "", 0 },
                    { new Guid("b6917754-f169-48ca-bbf4-0ce8e405c7d6"), "", false, "", "Bird", false, "Bird3", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("1555d866-1afa-45a2-a274-b30f684d9006"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("2f046260-fc5e-4944-b156-730d13d52057"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3a36b97f-77aa-4d8e-9d36-291333549f54"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3b42c83f-cb2a-4dee-9842-9ef9fa4fdabc"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("4a13a5c5-cd7d-4e34-b279-ea589005a5be"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("4d6b6906-38d2-46c2-98fb-f38f51d2d181"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5458be4e-ad9d-48e2-981d-bc48e3a2dadc"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("6c489eef-b0c2-4fb5-bbc2-f4b99b7b8913"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8043c9f5-cae6-42f3-a7a4-3f10065ef84d"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("976e4f1f-7c5f-4996-8ec6-53477c9979dd"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("b62a91e7-d729-4ead-b9d6-77e24a4d3f94"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("b6917754-f169-48ca-bbf4-0ce8e405c7d6"));

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
    }
}
