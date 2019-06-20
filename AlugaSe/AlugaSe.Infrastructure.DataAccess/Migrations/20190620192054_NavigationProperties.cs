using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlugaSe.Infrastructure.DataAccess.Migrations
{
    public partial class NavigationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentItems_Products_ProductId",
                table: "RentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RentItems_Rents_RentId",
                table: "RentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Rents",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RentId",
                table: "RentItems",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "RentItems",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RentItems_Products_ProductId",
                table: "RentItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentItems_Rents_RentId",
                table: "RentItems",
                column: "RentId",
                principalTable: "Rents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentItems_Products_ProductId",
                table: "RentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RentItems_Rents_RentId",
                table: "RentItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Rents",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "RentId",
                table: "RentItems",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "RentItems",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_RentItems_Products_ProductId",
                table: "RentItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentItems_Rents_RentId",
                table: "RentItems",
                column: "RentId",
                principalTable: "Rents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Customers_CustomerId",
                table: "Rents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
