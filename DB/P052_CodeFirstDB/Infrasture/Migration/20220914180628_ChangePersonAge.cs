using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P052_CodeFirstSqliteDb.Infrastructure.Migrations
{
    public partial class ChangePersonAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Persons",
                newName: "Height");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Persons",
                newName: "Age");
        }
    }
}
