using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P004EFApplication.Migrations
{
    /// <inheritdoc />
    public partial class nr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreatedDateTime", "ImagePath", "Name", "SpiceLevel", "Type" },
                values: new object[,]
                {
                    { 1, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 23, 178, DateTimeKind.Local).AddTicks(9991), "", "Fried Bread Sticks", "Mild", "Snacks" },
                    { 2, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 23, 179, DateTimeKind.Local).AddTicks(39), "", "Potato dumplings", "low", "Main dish" },
                    { 3, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 23, 179, DateTimeKind.Local).AddTicks(41), "", "Kibinai", "low", "Street Food" }
                });

            migrationBuilder.InsertData(
                table: "RecipyItems",
                columns: new[] { "RecipeItemId", "Calories", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, 150.0, 1, "Duona" },
                    { 2, 300.0, 1, "Chhese" },
                    { 3, 300.0, 1, "Mayo" },
                    { 4, 50.0, 1, "Garlic" },
                    { 5, 400.0, 2, "Potatos" },
                    { 6, 500.0, 2, "Meat" },
                    { 7, 300.0, 2, "SourCream" },
                    { 8, 300.0, 3, "Dought" },
                    { 9, 300.0, 3, "Meat" },
                    { 10, 300.0, 3, "Salt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipyItems",
                keyColumn: "RecipeItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);
        }
    }
}
