using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addedMenuListandMenuGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[] { 1, true, "MG_Users" });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 19, 26, 730, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ActionName", "Active", "Controller", "DisplayName", "MenuGroupId" },
                values: new object[,]
                {
                    { 1, "Index", true, "User", "Users", 1 },
                    { 2, "Index", true, "Unit", "Unit Management", 1 },
                    { 3, "Index", true, "Blog", "Blog Management", 1 },
                    { 4, "Index", true, "News", "News Management", 1 },
                    { 5, "UnApproveUsers", true, "User", "Approve Users", 1 },
                    { 6, "BoulevardList", true, "Boulevard", "Builders Boulevard", 1 },
                    { 7, "index", true, "Calender", "Calendar", 1 },
                    { 8, "index", true, "PictureAsset", "Picture Assets", 1 },
                    { 9, "index", true, "VideoAssets", "Video Assets", 1 },
                    { 10, "index", true, "Executive", "Executives", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(7600));
        }
    }
}
