using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P004EFApplication.Migrations
{
    /// <inheritdoc />
    public partial class pradine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    SpiceLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                });

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipyItems",
                columns: table => new
                {
                    RecipeItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipyItems", x => x.RecipeItemId);
                    table.ForeignKey(
                        name: "FK_RecipyItems_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreatedDateTime", "ImagePath", "Name", "SpiceLevel", "Type", "UpdatedDateTime" },
                values: new object[,]
                {
                    { 1, "Lithuania", new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9293), "", "Fried Bread Sticks", "Mild", "Snacks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Lithuania", new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9339), "", "Potato dumplings", "low", "Main dish", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lithuania", new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9342), "", "Kibinai", "low", "Street Food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

            migrationBuilder.CreateIndex(
                name: "IX_RecipyItems_DishId",
                table: "RecipyItems",
                column: "DishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DropTable(
                name: "RecipyItems");

            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
