ausing System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Murad.WebApi.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 2, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 3, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 12, 21, 23, 40, 441, DateTimeKind.Local).AddTicks(7216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 2, 2, 21, 21, 50, 546, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 1, 3, 21, 21, 50, 546, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2022, 12, 12, 21, 21, 50, 546, DateTimeKind.Local).AddTicks(9750));
        }
    }
}
