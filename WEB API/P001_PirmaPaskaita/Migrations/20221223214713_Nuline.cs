using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class Nuline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ECoverType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PublishYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EBookStatus = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    HasAmountOfBooks = table.Column<int>(type: "INTEGER", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LoyaltyPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    UserLevel = table.Column<string>(type: "TEXT", nullable: false),
                    WasOnline = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActualReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    PaidWithPoints = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UNotification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Topic = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UNotification_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "EBookStatus", "ECoverType", "PublishYear", "Stock", "Title", "Updated" },
                values: new object[,]
                {
                    { 1, "Several authors", "Registed", "Paperback", 1, 1, "The Bible", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1746) },
                    { 2, "Mao Zedong", "Registed", "Hardcover", 1964, 2, "Quotations from Chairman Mao Tse-Tung", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1787) },
                    { 3, "Several authors", "Registed", "Hardcover", 700, 3, "The Quran", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1790) },
                    { 4, "John Tolkien", "Registed", "Hardcover", 1954, 4, "The Lord Of The Rings", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1792) },
                    { 5, "Antoine de Saint-Exupery", "Registed", "Electronic", 1943, 5, "Le Petit Prince", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1794) },
                    { 6, "Joanne Rowling", "Registed", "Paperback", 1997, 6, "Harry Potter and the Philosopher’s Stone", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1796) },
                    { 7, "Robert Baden-Powell", "Registed", "Paperback", 1908, 7, "Scouting for Boys", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1798) },
                    { 8, "Agatha Christie", "Registed", "Paperback", 1939, 8, "And Then There Were None", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1800) },
                    { 9, "John Tolkien ", "Registed", "Hardcover", 1937, 9, "The Hobbit", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1802) },
                    { 10, "Cao Xueqin", "Registed", "Paperback", 1791, 10, "The Dream Of The Red Chambe", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1804) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LocalUserId",
                table: "Reservations",
                column: "LocalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UNotification_LocalUserId",
                table: "UNotification",
                column: "LocalUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "UNotification");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "LocalUsers");
        }
    }
}
