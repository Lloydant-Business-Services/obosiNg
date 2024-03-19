using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Menu_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ActionName", "Active", "Controller", "DisplayName", "MenuGroupId" },
                values: new object[] { 11, "Index", true, "About", "About", 1 });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 55, 32, 828, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.InsertData(
                table: "MenuInRole",
                columns: new[] { "Id", "MenuId", "RoleId" },
                values: new object[] { 11, 11, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuInRole",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 18, 9, 3, 7, 214, DateTimeKind.Local).AddTicks(390));
        }
    }
}
