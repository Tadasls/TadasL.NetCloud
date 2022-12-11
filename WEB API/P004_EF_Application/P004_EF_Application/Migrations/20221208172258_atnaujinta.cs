using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P004EFApplication.Migrations
{
    /// <inheritdoc />
    public partial class atnaujinta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "LocalUsers",
                newName: "Role");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 58, 280, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 58, 280, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 22, 58, 280, DateTimeKind.Local).AddTicks(8379));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "LocalUsers");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "LocalUsers",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 51, 5, 30, DateTimeKind.Local).AddTicks(9342));
        }
    }
}
