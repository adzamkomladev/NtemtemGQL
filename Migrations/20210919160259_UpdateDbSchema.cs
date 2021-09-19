using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class UpdateDbSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkPeriod_Organizations_OrganizationId",
                table: "WorkPeriod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkPeriod",
                table: "WorkPeriod");

            migrationBuilder.RenameTable(
                name: "WorkPeriod",
                newName: "WorkPeriods");

            migrationBuilder.RenameIndex(
                name: "IX_WorkPeriod_OrganizationId",
                table: "WorkPeriods",
                newName: "IX_WorkPeriods_OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkPeriods",
                table: "WorkPeriods",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 19, 16, 2, 59, 39, DateTimeKind.Utc).AddTicks(3193), new DateTime(2021, 9, 19, 16, 2, 59, 39, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 19, 16, 2, 59, 39, DateTimeKind.Utc).AddTicks(3726), new DateTime(2021, 9, 19, 16, 2, 59, 39, DateTimeKind.Utc).AddTicks(3728) });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkPeriods_Organizations_OrganizationId",
                table: "WorkPeriods",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkPeriods_Organizations_OrganizationId",
                table: "WorkPeriods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkPeriods",
                table: "WorkPeriods");

            migrationBuilder.RenameTable(
                name: "WorkPeriods",
                newName: "WorkPeriod");

            migrationBuilder.RenameIndex(
                name: "IX_WorkPeriods_OrganizationId",
                table: "WorkPeriod",
                newName: "IX_WorkPeriod_OrganizationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkPeriod",
                table: "WorkPeriod",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 3, 8, 49, 327, DateTimeKind.Utc).AddTicks(1021), new DateTime(2021, 9, 18, 3, 8, 49, 327, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 3, 8, 49, 327, DateTimeKind.Utc).AddTicks(1528), new DateTime(2021, 9, 18, 3, 8, 49, 327, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkPeriod_Organizations_OrganizationId",
                table: "WorkPeriod",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
