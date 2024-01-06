using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Felhantering : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("1a930ea1-fe7c-41c5-8498-2446a3aa4a5a"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("1a9a4b32-5b7a-4dd3-8130-aa56abe5e9cf"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("210c1ff7-f7b2-43fd-800f-0b72850f2f91"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("39110df4-fb03-48a2-b2c0-9e2facb9f3c6"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("3fd394da-d25d-4a47-8bc1-87359df90448"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("663f67b4-7df7-459c-96dc-63d73b6559ae"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("933ed8df-914b-444b-bc25-47458e842880"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("b6055470-5f97-4fd9-bd92-3314d087c498"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("c8edbd3d-5992-45b9-b720-d4f07e1f45bb"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("d99cc4c5-c255-489f-8c5e-6be044823638"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("ec9b1149-7dfb-40ef-9e8e-8bd69b060995"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("f0c15bb5-729f-4f3d-9402-4f7619ef6ab3"));

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[] { new Guid("085db9b8-07bf-48ac-9c4e-4a118c1969a8"), "Dog1", "Breed1", "Dog", 1 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "CanFly", "Color", "Discriminator" },
                values: new object[] { new Guid("18dd5587-9fa5-4a9b-9ae2-b52ed2b57666"), "Bird3", true, "Green", "Bird" });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[] { new Guid("3e1ff01a-de09-4084-b0a1-4de4cea7938b"), "Cat4", "Breed4", "Cat", false, 4 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("3f06942c-e5cd-4597-82cb-1c7c91ae6cdd"), "Dog2", "Breed2", "Dog", 2 },
                    { new Guid("47a89ef6-3192-4793-963d-f10fc87a8941"), "Dog3", "Breed3", "Dog", 3 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[] { new Guid("58b34ec0-f03c-45de-b78d-217b1320d446"), "Cat1", "Breed1", "Cat", true, 1 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "CanFly", "Color", "Discriminator" },
                values: new object[] { new Guid("702023ef-3bf5-4be8-9b2b-4c343ef3e5db"), "Bird1", true, "Red", "Bird" });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[] { new Guid("83ad5af3-f482-4655-a70d-0c7e1041f2df"), "Cat3", "Breed3", "Cat", true, 3 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[] { new Guid("96e096d6-0cd6-4c45-9abb-4e73417b07c4"), "Dog4", "Breed4", "Dog", 4 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[] { new Guid("a31e2635-50f5-4862-b0b1-4a52ad40e132"), "Cat2", "Breed2", "Cat", false, 2 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "CanFly", "Color", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b4fd2ec6-2ace-47e6-84b8-ca309e596034"), "Bird2", false, "Blue", "Bird" },
                    { new Guid("fdff8274-91cb-4d7d-9add-06f42753eae5"), "Bird4", false, "Yellow", "Bird" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("085db9b8-07bf-48ac-9c4e-4a118c1969a8"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("18dd5587-9fa5-4a9b-9ae2-b52ed2b57666"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("3e1ff01a-de09-4084-b0a1-4de4cea7938b"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("3f06942c-e5cd-4597-82cb-1c7c91ae6cdd"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("47a89ef6-3192-4793-963d-f10fc87a8941"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("58b34ec0-f03c-45de-b78d-217b1320d446"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("702023ef-3bf5-4be8-9b2b-4c343ef3e5db"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("83ad5af3-f482-4655-a70d-0c7e1041f2df"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("96e096d6-0cd6-4c45-9abb-4e73417b07c4"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("a31e2635-50f5-4862-b0b1-4a52ad40e132"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("b4fd2ec6-2ace-47e6-84b8-ca309e596034"));

            migrationBuilder.DeleteData(
                table: "AnimalModels",
                keyColumn: "AnimalId",
                keyValue: new Guid("fdff8274-91cb-4d7d-9add-06f42753eae5"));

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[] { new Guid("1a930ea1-fe7c-41c5-8498-2446a3aa4a5a"), "Dog2", "Breed2", "Dog", 2 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[] { new Guid("1a9a4b32-5b7a-4dd3-8130-aa56abe5e9cf"), "Cat1", "Breed1", "Cat", true, 1 });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("210c1ff7-f7b2-43fd-800f-0b72850f2f91"), "Dog1", "Breed1", "Dog", 1 },
                    { new Guid("39110df4-fb03-48a2-b2c0-9e2facb9f3c6"), "Dog4", "Breed4", "Dog", 4 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Breed", "Discriminator", "LikesToPlay", "Weight" },
                values: new object[,]
                {
                    { new Guid("3fd394da-d25d-4a47-8bc1-87359df90448"), "Cat4", "Breed4", "Cat", false, 4 },
                    { new Guid("663f67b4-7df7-459c-96dc-63d73b6559ae"), "Cat2", "Breed2", "Cat", false, 2 },
                    { new Guid("933ed8df-914b-444b-bc25-47458e842880"), "Cat3", "Breed3", "Cat", true, 3 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "CanFly", "Color", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("b6055470-5f97-4fd9-bd92-3314d087c498"), "Bird4", false, "Yellow", "Bird" },
                    { new Guid("c8edbd3d-5992-45b9-b720-d4f07e1f45bb"), "Bird1", true, "Red", "Bird" },
                    { new Guid("d99cc4c5-c255-489f-8c5e-6be044823638"), "Bird3", true, "Green", "Bird" },
                    { new Guid("ec9b1149-7dfb-40ef-9e8e-8bd69b060995"), "Bird2", false, "Blue", "Bird" }
                });

            migrationBuilder.InsertData(
                table: "AnimalModels",
                columns: new[] { "AnimalId", "AnimalName", "Dog_Breed", "Discriminator", "Dog_Weight" },
                values: new object[] { new Guid("f0c15bb5-729f-4f3d-9402-4f7619ef6ab3"), "Dog3", "Breed3", "Dog", 3 });
        }
    }
}
