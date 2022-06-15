using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoStorageAPI.Migrations
{
    public partial class seedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChocolateType", "Price", "Weight" },
                values: new object[] { 1, 500f, 110 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 300f, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 0, 500f, 0, 20, 110 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 5, 3, 400f, 1, 4, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 6, 3, 600f, 1, 20, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 7, 3, 750f, 1, 20, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 8, 2, 400f, 1, 4, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 9, 2, 600f, 1, 20, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 10, 2, 750f, 1, 20, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 11, 4, 400f, 1, 4, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 12, 4, 600f, 1, 20, 180 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 13, 4, 750f, 1, 20, 300 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 14, 1, 350f, 2, 10, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 15, 1, 500f, 2, 20, 160 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 16, 0, 350f, 2, 20, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 17, 0, 500f, 2, 2, 160 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChocolateType", "Price", "Weight" },
                values: new object[] { 0, 300f, 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 500f, 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChocolateType", "Price", "ProductType", "Stock", "Weight" },
                values: new object[] { 1, 300f, 2, 4, 70 });
        }
    }
}
