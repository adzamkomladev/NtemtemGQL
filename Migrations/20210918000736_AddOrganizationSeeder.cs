using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NtemtemGQL.Migrations
{
    public partial class AddOrganizationSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[] { 1, "Achimota Hospital, Aggrey Street, Achimota", new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9302), "Achimota Hospital is a government hospital built to serve the Achimota community.", "adzamkomla.dev@gmail.com", "Achimota Hospital", "233553995074", new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "Email", "Name", "Phone", "UpdatedAt" },
                values: new object[] { 2, "Arkesel, #1 Nii Oga Street", new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9941), "Arkesel is a clouds communication company.", "adzamkomla@gmail.com", "Arkesel Company Limited", "233202442452", new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9943) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
