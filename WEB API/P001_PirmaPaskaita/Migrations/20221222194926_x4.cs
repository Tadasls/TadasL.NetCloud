using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class x4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UNotification_LocalUsers_LocalUserId",
                table: "UNotification");

            migrationBuilder.AlterColumn<int>(
                name: "LocalUserId",
                table: "UNotification",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UNotification_LocalUsers_LocalUserId",
                table: "UNotification",
                column: "LocalUserId",
                principalTable: "LocalUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UNotification_LocalUsers_LocalUserId",
                table: "UNotification");

            migrationBuilder.AlterColumn<int>(
                name: "LocalUserId",
                table: "UNotification",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_UNotification_LocalUsers_LocalUserId",
                table: "UNotification",
                column: "LocalUserId",
                principalTable: "LocalUsers",
                principalColumn: "Id");
        }
    }
}
