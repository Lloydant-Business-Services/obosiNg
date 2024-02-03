using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Catgoie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, true, "Politics" },
                    { 2, true, "Business & Economy" },
                    { 3, true, "Security & Defense" },
                    { 4, true, "Education" },
                    { 5, true, "Health" },
                    { 6, true, "Infrastructure" },
                    { 7, true, "Environment" },
                    { 8, true, "Science & Technology" },
                    { 9, true, "Sports" },
                    { 10, true, "Entertainment" },
                    { 11, true, "Fashion" },
                    { 12, true, "Food" },
                    { 13, true, "Travel & Tourism" },
                    { 14, true, "Diaspora" }
                });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 16, 59, 43, 538, DateTimeKind.Local).AddTicks(2415));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1495));
        }
    }
}
