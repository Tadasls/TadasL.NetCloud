using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class sesta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSeen",
                table: "UNotification",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 23, 1, 45, 379, DateTimeKind.Local).AddTicks(7461));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSeen",
                table: "UNotification");

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
    }
}
