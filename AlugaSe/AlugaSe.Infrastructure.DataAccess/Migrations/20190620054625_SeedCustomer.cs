using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    public partial class SeedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BirthDay", "Gender", "Identification", "Name" },
                values: new object[,]
                {
                    { new Guid("a4dc10ff-77dc-4260-b109-27ac65a75d54"), "Rua Carlos 124", new DateTime(1990, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "CNPJ 5345345435", "Carlos" },
                    { new Guid("d1bd9cdb-d519-411b-b320-49962b02fe28"), "Rua Maria 124", new DateTime(1986, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feminino", "CPF 5345345435", "Maria" }
                });

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
                value: "Casa de Festas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a4dc10ff-77dc-4260-b109-27ac65a75d54"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d1bd9cdb-d519-411b-b320-49962b02fe28"));

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
    }
}
