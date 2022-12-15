using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class ketvirta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "WasOnline",
                table: "LocalUsers",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WasOnline",
                table: "LocalUsers");
        }
    }
}
