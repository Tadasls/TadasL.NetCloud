using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBHomeWorkMusicSalesShop.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "tracks",
                type: "NUMERIC(10,2)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "NUMERIC(10,2)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "tracks",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "tracks");

            migrationBuilder.AlterColumn<byte[]>(
                name: "UnitPrice",
                table: "tracks",
                type: "NUMERIC(10,2)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(double),
                oldType: "NUMERIC(10,2)",
                oldNullable: true);
        }
    }
}
