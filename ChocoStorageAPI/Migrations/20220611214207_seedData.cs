using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoStorageAPI.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductType = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    ChocolateType = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Weight" },
                values: new object[] { 1, 1, 300f, 0, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Weight" },
                values: new object[] { 2, 0, 300f, 0, 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Weight" },
                values: new object[] { 3, 0, 500f, 0, 120 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ChocolateType", "Price", "ProductType", "Weight" },
                values: new object[] { 4, 1, 300f, 2, 70 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
