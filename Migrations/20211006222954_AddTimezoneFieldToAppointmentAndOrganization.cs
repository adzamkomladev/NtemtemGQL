using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class AddTimezoneFieldToAppointmentAndOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Timezone",
                table: "Organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Timezone",
                table: "Appointments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime", "Timezone" },
                values: new object[] { new DateTime(2021, 10, 11, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 11, 14, 30, 0, 0, DateTimeKind.Unspecified), "Africa/Accra" });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime", "Timezone" },
                values: new object[] { new DateTime(2021, 10, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), "Africa/Accra" });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime", "Timezone" },
                values: new object[] { new DateTime(2021, 10, 7, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), "Africa/Accra" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Timezone", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 29, 54, 111, DateTimeKind.Utc).AddTicks(1603), "Africa/Accra", new DateTime(2021, 10, 6, 22, 29, 54, 111, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Timezone", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 10, 6, 22, 29, 54, 111, DateTimeKind.Utc).AddTicks(2125), "Africa/Accra", new DateTime(2021, 10, 6, 22, 29, 54, 111, DateTimeKind.Utc).AddTicks(2127) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timezone",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Timezone",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 9, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 30, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 9, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2021, 9, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 21, 12, 50, 18, 918, DateTimeKind.Utc).AddTicks(6903), new DateTime(2021, 9, 21, 12, 50, 18, 918, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 21, 12, 50, 18, 918, DateTimeKind.Utc).AddTicks(7411), new DateTime(2021, 9, 21, 12, 50, 18, 918, DateTimeKind.Utc).AddTicks(7414) });
        }
    }
}
