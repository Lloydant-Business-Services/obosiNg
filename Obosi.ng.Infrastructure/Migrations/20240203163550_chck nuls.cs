using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class chcknuls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 17, 35, 49, 934, DateTimeKind.Local).AddTicks(6159));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
