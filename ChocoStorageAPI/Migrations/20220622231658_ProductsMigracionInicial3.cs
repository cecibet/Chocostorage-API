using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoStorageAPI.Migrations
{
    public partial class ProductsMigracionInicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sells_ProductId",
                table: "Sells");

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 22, 20, 16, 57, 948, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 6, 22, 20, 16, 57, 948, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.CreateIndex(
                name: "IX_Sells_ProductId",
                table: "Sells",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sells_ProductId",
                table: "Sells");

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 6, 21, 18, 45, 43, 502, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 6, 21, 18, 45, 43, 502, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.CreateIndex(
                name: "IX_Sells_ProductId",
                table: "Sells",
                column: "ProductId",
                unique: true);
        }
    }
}
