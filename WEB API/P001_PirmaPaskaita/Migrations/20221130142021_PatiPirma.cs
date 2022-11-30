using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class PatiPirma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECoverType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ECoverType", "PublishYear", "Title" },
                values: new object[,]
                {
                    { 1, "Several authors", "Paperback", 1, "The Bible" },
                    { 2, "Mao Zedong", "Hardcover", 1964, "Quotations from Chairman Mao Tse-Tung" },
                    { 3, "Several authors", "Hardcover", 700, "The Quran" },
                    { 4, "John Tolkien", "Hardcover", 1954, "The Lord Of The Rings" },
                    { 5, "Antoine de Saint-Exupery", "Electronic", 1943, "Le Petit Prince" },
                    { 6, "Joanne Rowling", "Paperback", 1997, "Harry Potter and the Philosopher’s Stone" },
                    { 7, "Robert Baden-Powell", "Paperback", 1908, "Scouting for Boys" },
                    { 8, "Agatha Christie", "Paperback", 1939, "And Then There Were None" },
                    { 9, "John Tolkien ", "Hardcover", 1937, "The Hobbit" },
                    { 10, "Cao Xueqin", "Paperback", 1791, "The Dream Of The Red Chambe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
