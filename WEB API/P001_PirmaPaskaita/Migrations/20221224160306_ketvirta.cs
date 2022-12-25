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
            migrationBuilder.AlterColumn<string>(
                name: "ECoverType",
                table: "Books",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 3, 6, 3, DateTimeKind.Local).AddTicks(7313));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ECoverType",
                table: "Books",
                type: "TEXT",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6945));
        }
    }
}
