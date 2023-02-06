using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Murad.WebApi.Migrations
{
    public partial class AddData_and_fixWarn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2023, 2, 2, 15, 26, 57, 311, DateTimeKind.Local).AddTicks(377), "https://amazoncomp.az/wp-content/uploads/2020/08/Lenovo-IdeaPad-L3-15IML05.jpg", "Lenovo Ideapad", 1750m, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2023, 1, 3, 15, 26, 57, 311, DateTimeKind.Local).AddTicks(7933), "https://www.tradeinn.com/f/13796/137965389/oneplus-nord-8gb-128gb-6.44-smartphone.jpg", "OnePlus", 1450m, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedTime", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 12, 12, 15, 26, 57, 311, DateTimeKind.Local).AddTicks(7948), "https://strgimgr.umico.az/sized/1680/258600-e3d5563b2275dac6f48948047bebb250.jpg", "Mibro Watch X1", 82m, 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
