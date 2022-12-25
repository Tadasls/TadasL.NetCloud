using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class trecia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Stock", "Updated" },
                values: new object[] { 1, new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Stock", "Updated" },
                values: new object[] { 1, new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EBookStatus", "Stock", "Updated" },
                values: new object[] { "WishListed", 1, new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EBookStatus", "Stock", "Updated" },
                values: new object[] { "WishListed", 1, new DateTime(2022, 12, 24, 18, 1, 49, 759, DateTimeKind.Local).AddTicks(6945) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Stock", "Updated" },
                values: new object[] { 7, new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Stock", "Updated" },
                values: new object[] { 8, new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EBookStatus", "Stock", "Updated" },
                values: new object[] { "OnSale", 9, new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EBookStatus", "Stock", "Updated" },
                values: new object[] { "OnSale", 10, new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8421) });
        }
    }
}
