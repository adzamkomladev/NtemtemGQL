using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class UpdateNameFieldToDayInWorkPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WorkPeriod",
                newName: "Day");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 3, 1, 17, 47, DateTimeKind.Utc).AddTicks(6356), new DateTime(2021, 9, 18, 3, 1, 17, 47, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 18, 3, 1, 17, 47, DateTimeKind.Utc).AddTicks(6872), new DateTime(2021, 9, 18, 3, 1, 17, 47, DateTimeKind.Utc).AddTicks(6874) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Day",
                table: "WorkPeriod",
                newName: "Name");

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
        }
    }
}
