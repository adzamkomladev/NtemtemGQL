using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class AddWorkPeriodToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrganizationId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    StartTime = table.Column<string>(type: "TEXT", nullable: false),
                    EndTime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPeriod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPeriod_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7051), new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7675), new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.CreateIndex(
                name: "IX_WorkPeriod_OrganizationId",
                table: "WorkPeriod",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPeriod");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9302), new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9941), new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9943) });
        }
    }
}
