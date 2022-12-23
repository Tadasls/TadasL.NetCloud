using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class antra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WasOnlineWeekNumber",
                table: "LocalUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "WishListed", new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "WishListed", new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "OnSale", new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "OnSale", new DateTime(2022, 12, 24, 0, 54, 30, 991, DateTimeKind.Local).AddTicks(8421) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WasOnlineWeekNumber",
                table: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Updated",
                value: new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "Registed", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "Registed", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "Registed", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EBookStatus", "Updated" },
                values: new object[] { "Registed", new DateTime(2022, 12, 23, 23, 47, 13, 431, DateTimeKind.Local).AddTicks(1804) });
        }
    }
}
