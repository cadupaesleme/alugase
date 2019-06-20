using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    public partial class SeedTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30bc9b1f-999a-4e14-895d-a02c010a2c6f"),
                column: "Name",
                value: "BMWx");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("7159143a-ab92-4a47-85d0-6768560e6504"),
                column: "Name",
                value: "Casa de FestasASA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30bc9b1f-999a-4e14-895d-a02c010a2c6f"),
                column: "Name",
                value: "BMW");

            migrationBuilder.UpdateData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("7159143a-ab92-4a47-85d0-6768560e6504"),
                column: "Name",
                value: "Casa de Festa");
        }
    }
}
