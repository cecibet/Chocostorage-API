using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoStorageAPI.Migrations
{
    public partial class ProductsMigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductType = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    ChocolateType = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<float>(type: "REAL", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Sells",
                columns: table => new
                {
                    SellId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalCost = table.Column<float>(type: "REAL", nullable: false),
                    ShippingType = table.Column<int>(type: "INTEGER", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sells", x => x.SellId);
                    table.ForeignKey(
                        name: "FK_Sells_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 1, 1, 0, 50, 300f, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 2, 1, 0, 20, 500f, 110 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 3, 0, 0, 20, 300f, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 4, 0, 0, 20, 500f, 110 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 5, 3, 1, 4, 400f, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 6, 3, 1, 20, 600f, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 7, 3, 1, 20, 750f, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 8, 2, 1, 4, 400f, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 9, 2, 1, 20, 600f, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 10, 2, 1, 20, 750f, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 11, 4, 1, 4, 400f, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 12, 4, 1, 20, 600f, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 13, 4, 1, 20, 750f, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 14, 1, 2, 10, 350f, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 15, 1, 2, 20, 500f, 160 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 16, 0, 2, 20, 350f, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ChocolateType", "ProductType", "Stock", "UnitPrice", "Weight" },
                values: new object[] { 17, 0, 2, 2, 500f, 160 });

            migrationBuilder.InsertData(
                table: "Sells",
                columns: new[] { "SellId", "Date", "ProductId", "Quantity", "ShippingType", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 6, 21, 18, 45, 43, 502, DateTimeKind.Local).AddTicks(778), 2, 5, 0, 2500f });

            migrationBuilder.InsertData(
                table: "Sells",
                columns: new[] { "SellId", "Date", "ProductId", "Quantity", "ShippingType", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 6, 21, 18, 45, 43, 502, DateTimeKind.Local).AddTicks(789), 3, 5, 1, 3000f });

            migrationBuilder.CreateIndex(
                name: "IX_Sells_ProductId",
                table: "Sells",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sells");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
