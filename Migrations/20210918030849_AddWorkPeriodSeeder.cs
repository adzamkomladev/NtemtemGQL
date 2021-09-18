using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class AddWorkPeriodSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 1, "Monday", "23:00", 1, "02:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 2, "Tuesday", "23:00", 1, "02:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 3, "Wednesday", "23:00", 1, "02:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 4, "Thursday", "23:00", 1, "02:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 5, "Friday", "23:00", 1, "02:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 6, "Monday", "17:00", 2, "09:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 7, "Tuesday", "17:00", 2, "09:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 8, "Wednesday", "17:00", 2, "09:00" });

            migrationBuilder.InsertData(
                table: "WorkPeriod",
                columns: new[] { "Id", "Day", "EndTime", "OrganizationId", "StartTime" },
                values: new object[] { 9, "Thursday", "14:00", 2, "09:00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WorkPeriod",
                keyColumn: "Id",
                keyValue: 9);

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
    }
}
