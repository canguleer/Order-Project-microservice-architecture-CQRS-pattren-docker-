using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ordering.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Order",
                columns: new[] { "Id", "BrandId", "CreatedOn", "CustomerName", "Price", "Status", "StoreName" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2022, 2, 5, 12, 20, 37, 78, DateTimeKind.Local).AddTicks(8521), "Can Güler", 17m, 10, "Shopi" },
                    { 2, 5, new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2274), "Mehmet Güler", 55m, 50, "Shopi" },
                    { 3, 2, new DateTime(2021, 12, 17, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2493), "Ahmet Güler", 60m, 30, "Shopi" },
                    { 4, 2, new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2505), "Feyza Güler", 90m, 40, "Shopi" },
                    { 5, 8, new DateTime(2022, 1, 31, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2509), "Enise Güler", 70m, 10, "Shopi" },
                    { 6, 7, new DateTime(2022, 1, 27, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2520), "Adem Güler", 50m, 20, "Shopi" },
                    { 7, 6, new DateTime(2021, 12, 2, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2524), "Şimşek Güler", 220m, 10, "Shopi" },
                    { 8, 5, new DateTime(2021, 11, 9, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2528), "Abdullah Güler", 87m, 10, "Shopi" },
                    { 9, 21, new DateTime(2022, 1, 25, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2531), "Nurullah Güler", 65m, 10, "Shopi" },
                    { 10, 14, new DateTime(2022, 1, 29, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2537), "Enes Güler", 65m, 10, "Shopi" },
                    { 11, 2, new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2540), "Emel Güler", 87m, 10, "Shopi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order",
                schema: "dbo");
        }
    }
}
