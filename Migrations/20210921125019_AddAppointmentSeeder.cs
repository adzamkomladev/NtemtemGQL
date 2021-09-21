using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class AddAppointmentSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientEmail", "ClientName", "ClientPhone", "CreatedAt", "EndTime", "ExtraInfo", "OrganizationId", "Reason", "StartTime", "Status", "UpdatedAt" },
                values: new object[] { 1, "adzamkomla@gmail.com", "Komla Adzam", "0553995074", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 30, 15, 30, 0, 0, DateTimeKind.Unspecified), "This meeting is with Dr. Philip Kpone.", 1, "This is an appointment to meet the head dematologist.", new DateTime(2021, 9, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), "SCHEDULED", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientEmail", "ClientName", "ClientPhone", "CreatedAt", "EndTime", "ExtraInfo", "OrganizationId", "Reason", "StartTime", "Status", "UpdatedAt" },
                values: new object[] { 2, "adzamkomla.dev@gmail.com", "Etorenyo Adzam", "0553995074", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 29, 15, 30, 0, 0, DateTimeKind.Unspecified), "This meeting is with Dr. Anna Kpone.", 1, "This is an appointment to meet the head opthalmologist.", new DateTime(2021, 9, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), "SCHEDULED", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "ClientEmail", "ClientName", "ClientPhone", "CreatedAt", "EndTime", "ExtraInfo", "OrganizationId", "Reason", "StartTime", "Status", "UpdatedAt" },
                values: new object[] { 3, "adzamkomla.dev@gmail.com", "Etorenyo Adzam", "0553995074", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 29, 10, 30, 0, 0, DateTimeKind.Unspecified), "This meeting is with Mr. Godwin Amefia.", 2, "This is an appointment to meet the manager of operations of Arkesel.", new DateTime(2021, 9, 29, 9, 0, 0, 0, DateTimeKind.Unspecified), "SCHEDULED", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6275), new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6783), new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6786) });
        }
    }
}
