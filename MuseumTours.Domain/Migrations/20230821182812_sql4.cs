using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MuseumTours.Domain.Migrations
{
    public partial class sql4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(type: "integer", nullable: false),
                    ExcursionId = table.Column<int>(type: "integer", nullable: false),
                    ExcursionId1 = table.Column<int>(type: "integer", nullable: true),
                    NumberOfPersons = table.Column<int>(type: "integer", nullable: false),
                    Payment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Clients_ExcursionId",
                        column: x => x.ExcursionId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Excursions_ExcursionId1",
                        column: x => x.ExcursionId1,
                        principalTable: "Excursions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ExcursionId",
                table: "Applications",
                column: "ExcursionId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ExcursionId1",
                table: "Applications",
                column: "ExcursionId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
