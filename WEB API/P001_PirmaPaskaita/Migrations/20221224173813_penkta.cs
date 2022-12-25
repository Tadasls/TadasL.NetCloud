using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class penkta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WasOnline",
                table: "LocalUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 19, 38, 13, 70, DateTimeKind.Local).AddTicks(8577));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "WasOnline",
                table: "LocalUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

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
    }
}
