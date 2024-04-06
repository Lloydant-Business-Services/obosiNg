using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatesformenus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ActionName", "Active", "Controller", "DisplayName", "MenuGroupId" },
                values: new object[] { 14, "Index", true, "DropDown", "Setup Drop Down", 1 });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 4, 6, 8, 35, 33, 827, DateTimeKind.Local).AddTicks(7118));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5319));
        }
    }
}
