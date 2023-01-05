using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartitionUzd.Migrations
{
    public partial class nuline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partitionKey = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.id);
                    table.UniqueConstraint("AK_Projects_partitionKey", x => x.partitionKey)
                        .Annotation("SqlServer:Clustered", true);
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
                    tenant = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userPrincipalName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    objectId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deleted = table.Column<bool>(type: "bit", nullable: false),
                    Rootid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.tenant);
                    table.UniqueConstraint("AK_Tenants_userPrincipalName", x => x.userPrincipalName)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Tenants_Roots_Rootid",
                        column: x => x.Rootid,
                        principalTable: "Roots",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    alternate = table.Column<bool>(type: "bit", nullable: false),
                    tenant = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.email);
                    table.ForeignKey(
                        name: "FK_Emails_Tenants_tenant",
                        column: x => x.tenant,
                        principalTable: "Tenants",
                        principalColumn: "tenant");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_tenant",
                table: "Emails",
                column: "tenant");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_Rootid",
                table: "Tenants",
                column: "Rootid");
        }

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
