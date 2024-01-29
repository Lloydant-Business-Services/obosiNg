using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesforOduBranches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "About", "BackGroundImageUrl", "DateCreated", "Description", "Name", "NeedsConfirmation", "UnitTypeId" },
                values: new object[,]
                {
                    { 1, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7143), null, "Umuota", false, 1 },
                    { 2, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7168), null, "Mmakwum", false, 1 },
                    { 3, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7171), null, "Uruowulu", false, 1 },
                    { 4, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7173), null, "Ugamuma", false, 1 },
                    { 5, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7175), null, "Ire", false, 1 },
                    { 6, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7177), null, "Lagos", false, 5 },
                    { 7, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7179), null, "Abuja", false, 5 },
                    { 8, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7182), null, "Port Harcourt", false, 5 },
                    { 9, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7184), null, "Aba", false, 5 },
                    { 10, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7186), null, "Abakaliki", false, 5 },
                    { 11, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7201), null, "Awka", false, 5 },
                    { 12, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7205), null, "Benin City", false, 5 },
                    { 13, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7207), null, "Enugu", false, 5 },
                    { 14, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7209), null, "Jos", false, 5 },
                    { 15, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7211), null, "Kaduna", false, 5 },
                    { 16, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7213), null, "Makurdi", false, 5 },
                    { 17, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7215), null, "Nnewi", false, 5 },
                    { 18, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7219), null, "Suleja", false, 5 },
                    { 19, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7221), null, "Warri", false, 5 },
                    { 20, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7223), null, "Umuota", false, 5 },
                    { 21, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7227), null, "Mmakwum", false, 5 },
                    { 22, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7229), null, "Uruowulu", false, 5 },
                    { 23, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7231), null, "Ugamuma", false, 5 },
                    { 24, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7233), null, "Ire", false, 5 },
                    { 25, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7235), null, "OWA UK", false, 5 },
                    { 26, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7237), null, "ODA USA", false, 5 },
                    { 27, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7239), null, "ODU South Africa", false, 5 },
                    { 28, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7241), null, "ODU Brazil", false, 5 },
                    { 29, "", "", new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7243), null, "ODU Kuwait", false, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29);
        }
    }
}
