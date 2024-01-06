using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewSettingForAddNewBird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OwnerUserName",
                table: "AnimalModel");

            migrationBuilder.AddColumn<Guid>(
                name: "Key",
                table: "UserAnimals",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TheyAreToGetherIndex",
                table: "UserAnimals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "AnimalModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "LikesToPlay",
                table: "AnimalModel",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "CanFly",
                table: "AnimalModel",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Dog_Breed",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dog_Weight",
                table: "AnimalModel",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("0bea58a2-5114-47f5-b651-f8a088df35cb"), false, "Blue", "Bird", "Bird2" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("0f99034f-c3ab-422e-a27d-2628daa3a17c"), "Breed1", "Cat", true, "Cat1", 1 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[,]
                {
                    { new Guid("1cb1191b-d50d-49df-a247-fb56f749e6c7"), "Breed2", "Dog", "Dog2", 2 },
                    { new Guid("533282ae-a1e6-42e3-b8ca-297542e01944"), "Breed4", "Dog", "Dog4", 4 }
                });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("5938031e-9e5a-4cfd-9d3f-2ff23af3ae4f"), false, "Yellow", "Bird", "Bird4" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("7b6e2898-6819-46da-98cb-84cc908d2333"), "Breed3", "Cat", true, "Cat3", 3 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("7c2927d8-4c03-435e-b3e4-d32e8bd0b4a5"), true, "Red", "Bird", "Bird1" });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("8582d7a0-4c3f-4102-b2f8-ef0f675d8b5f"), "Breed3", "Dog", "Dog3", 3 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("863249d8-d2b0-4640-9631-848fb046ced7"), "Breed4", "Cat", false, "Cat4", 4 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Dog_Breed", "Discriminator", "Name", "Dog_Weight" },
                values: new object[] { new Guid("a81bf7a6-e99b-4266-9857-d85442df5a38"), "Breed1", "Dog", "Dog1", 1 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "Breed", "Discriminator", "LikesToPlay", "Name", "Weight" },
                values: new object[] { new Guid("a97a991c-3a89-4930-b659-cdee9923022a"), "Breed2", "Cat", false, "Cat2", 2 });

            migrationBuilder.InsertData(
                table: "AnimalModel",
                columns: new[] { "Id", "CanFly", "Color", "Discriminator", "Name" },
                values: new object[] { new Guid("d9b654e1-980d-4afb-b7ad-f190dd69fe55"), true, "Green", "Bird", "Bird3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("0bea58a2-5114-47f5-b651-f8a088df35cb"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("0f99034f-c3ab-422e-a27d-2628daa3a17c"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("1cb1191b-d50d-49df-a247-fb56f749e6c7"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("533282ae-a1e6-42e3-b8ca-297542e01944"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("5938031e-9e5a-4cfd-9d3f-2ff23af3ae4f"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("7b6e2898-6819-46da-98cb-84cc908d2333"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("7c2927d8-4c03-435e-b3e4-d32e8bd0b4a5"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("8582d7a0-4c3f-4102-b2f8-ef0f675d8b5f"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("863249d8-d2b0-4640-9631-848fb046ced7"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("a81bf7a6-e99b-4266-9857-d85442df5a38"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("a97a991c-3a89-4930-b659-cdee9923022a"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("d9b654e1-980d-4afb-b7ad-f190dd69fe55"));

            migrationBuilder.DropColumn(
                name: "Key",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "TheyAreToGetherIndex",
                table: "UserAnimals");

            migrationBuilder.DropColumn(
                name: "Dog_Breed",
                table: "AnimalModel");

            migrationBuilder.DropColumn(
                name: "Dog_Weight",
                table: "AnimalModel");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "AnimalModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "LikesToPlay",
                table: "AnimalModel",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "CanFly",
                table: "AnimalModel",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerUserName",
                table: "AnimalModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
