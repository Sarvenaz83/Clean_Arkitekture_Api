using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("1b2d0e12-a29f-4d8d-b295-5e55411e26f6"), "", false, "", "Bird", false, "Bird1", "", 0 },
                    { new Guid("22af3256-6a59-4655-864a-984718224267"), "", false, "", "Bird", false, "Bird4", "", 0 },
                    { new Guid("3cb6d2d7-b0a9-40b1-bb6f-24d4550f46d3"), "", false, "", "Cat", false, "Cat1", "", 0 },
                    { new Guid("7b6aa0ea-1ee0-4b07-bdc9-43eaeea997e3"), "", false, "", "Dog", false, "Dog4", "", 0 },
                    { new Guid("9513316a-4d18-4860-9dbc-8b4cc29f791a"), "", false, "", "Dog", false, "Dog1", "", 0 },
                    { new Guid("975fdae5-bb54-42ed-b47c-0dcdc126edef"), "", false, "", "Cat", false, "Cat2", "", 0 },
                    { new Guid("9b72c5bb-9c57-497d-b507-aff7a41217f1"), "", false, "", "Bird", false, "Bird3", "", 0 },
                    { new Guid("da4c773e-1c02-4bb6-9f20-09a1be2d0349"), "", false, "", "Cat", false, "Cat4", "", 0 },
                    { new Guid("df79a316-d621-49b0-a18b-2b8be83ded9b"), "", false, "", "Cat", false, "Cat3", "", 0 },
                    { new Guid("e12d6224-c380-45a6-ad78-1b830a37ef1e"), "", false, "", "Bird", false, "Bird2", "", 0 },
                    { new Guid("e24e9641-513a-4bfa-8685-0c9d3dadd2e9"), "", false, "", "Dog", false, "Dog2", "", 0 },
                    { new Guid("f0b66ccd-0f3e-4ab2-b2f5-4c5cfa9313dd"), "", false, "", "Dog", false, "Dog3", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("1b2d0e12-a29f-4d8d-b295-5e55411e26f6"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("22af3256-6a59-4655-864a-984718224267"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("3cb6d2d7-b0a9-40b1-bb6f-24d4550f46d3"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("7b6aa0ea-1ee0-4b07-bdc9-43eaeea997e3"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("9513316a-4d18-4860-9dbc-8b4cc29f791a"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("975fdae5-bb54-42ed-b47c-0dcdc126edef"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("9b72c5bb-9c57-497d-b507-aff7a41217f1"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("da4c773e-1c02-4bb6-9f20-09a1be2d0349"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("df79a316-d621-49b0-a18b-2b8be83ded9b"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("e12d6224-c380-45a6-ad78-1b830a37ef1e"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("e24e9641-513a-4bfa-8685-0c9d3dadd2e9"));

            migrationBuilder.DeleteData(
                table: "AnimalModel",
                keyColumn: "Id",
                keyValue: new Guid("f0b66ccd-0f3e-4ab2-b2f5-4c5cfa9313dd"));

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
    }
}
