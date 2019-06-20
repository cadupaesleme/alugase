using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Address", "BirthDay", "Gender", "Identification", "Name" },
                values: new object[] { new Guid("7159143a-ab92-4a47-85d0-6768560e6504"), "Rua Teste 124", null, "Feminino", "CNPJ 5345345435", "Casa de Festa" });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Address", "BirthDay", "Gender", "Identification", "Name" },
                values: new object[] { new Guid("611658e4-461d-4de6-8a5e-4899a306dee2"), "Rua João 124", new DateTime(1988, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "CPF 5345345435", "João" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "UnitPrice", "VendorId" },
                values: new object[,]
                {
                    { new Guid("c0bc4b28-2d10-4951-8ea7-b0a4ebf81648"), "Carrocinha para fazer pizza", "Carrocinha de Pizza", 200m, new Guid("7159143a-ab92-4a47-85d0-6768560e6504") },
                    { new Guid("2efa35c5-befe-42d1-afbe-017a1fef314c"), "Pula Pula", "Pula Pula", 300m, new Guid("7159143a-ab92-4a47-85d0-6768560e6504") },
                    { new Guid("30bc9b1f-999a-4e14-895d-a02c010a2c6f"), "Carro BMW", "BMW", 10000m, new Guid("611658e4-461d-4de6-8a5e-4899a306dee2") },
                    { new Guid("56021d7b-30cc-46e8-ba39-18d022928f50"), "Projeto de Video", "Projetor", 100m, new Guid("611658e4-461d-4de6-8a5e-4899a306dee2") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2efa35c5-befe-42d1-afbe-017a1fef314c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("30bc9b1f-999a-4e14-895d-a02c010a2c6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56021d7b-30cc-46e8-ba39-18d022928f50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0bc4b28-2d10-4951-8ea7-b0a4ebf81648"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("611658e4-461d-4de6-8a5e-4899a306dee2"));

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("7159143a-ab92-4a47-85d0-6768560e6504"));
        }
    }
}
