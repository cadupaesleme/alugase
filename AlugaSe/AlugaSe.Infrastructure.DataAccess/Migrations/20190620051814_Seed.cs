using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Id", "Address", "BirthDay", "Gender", "Identification", "Name" },
                values: new object[] { new Guid("e823d093-e99b-4837-9bcc-e763d9d27647"), "Rua Teste 124", null, "Feminino", "CNPJ 5345345435", "Casa de Festa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "Id",
                keyValue: new Guid("e823d093-e99b-4837-9bcc-e763d9d27647"));
        }
    }
}
