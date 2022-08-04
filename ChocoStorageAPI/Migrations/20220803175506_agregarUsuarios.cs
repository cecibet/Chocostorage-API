using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocoStorageAPI.Migrations
{
    public partial class agregarUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    SurName = table.Column<string>(type: "TEXT", maxLength: 32, nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 8, 3, 14, 55, 6, 22, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Sells",
                keyColumn: "SellId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 8, 3, 14, 55, 6, 22, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "SurName", "UserName" },
                values: new object[] { 1, "Cecilia", "ceci123", 0, "Bettiol", "cecibet" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "SurName", "UserName" },
                values: new object[] { 2, "Fabrizio", "fabra456", 1, "De Lisa", "fadelis" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password", "Role", "SurName", "UserName" },
                values: new object[] { 3, "Lucas", "lucas789", 1, "De Lorenzi", "lukedelo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
        }
    }
}
