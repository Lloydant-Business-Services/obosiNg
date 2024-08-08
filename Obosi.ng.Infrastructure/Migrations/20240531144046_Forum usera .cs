using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Forumusera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanContribute",
                table: "ForumFollowers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 31, 15, 40, 45, 873, DateTimeKind.Local).AddTicks(1391));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanContribute",
                table: "ForumFollowers");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2340));
        }
    }
}
