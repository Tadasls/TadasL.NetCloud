using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PressentC.Migrations
{
    /// <inheritdoc />
    public partial class nuline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PartitionKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    partitionKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    objectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPrincipalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deleted = table.Column<bool>(type: "bit", nullable: false),
                    Rootid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.objectId);
                    table.ForeignKey(
                        name: "FK_Tenants_Roots_Rootid",
                        column: x => x.Rootid,
                        principalTable: "Roots",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    alternative = table.Column<bool>(type: "bit", nullable: false),
                    tenantobjectId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.email);
                    table.ForeignKey(
                        name: "FK_Emails_Tenants_tenantobjectId",
                        column: x => x.tenantobjectId,
                        principalTable: "Tenants",
                        principalColumn: "objectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_tenantobjectId",
                table: "Emails",
                column: "tenantobjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Rootid",
                table: "Tenants",
                column: "Rootid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Roots");
        }
    }
}
