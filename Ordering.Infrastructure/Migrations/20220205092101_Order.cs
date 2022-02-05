using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ordering.Infrastructure.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 5, 12, 21, 0, 811, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 17, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 31, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 27, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 2, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 9, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 25, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 29, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 21, 0, 816, DateTimeKind.Local).AddTicks(7819));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2022, 2, 5, 12, 20, 37, 78, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 17, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 31, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 27, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2021, 12, 2, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 9, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 25, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 29, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Order",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2022, 1, 26, 12, 20, 37, 82, DateTimeKind.Local).AddTicks(2540));
        }
    }
}
