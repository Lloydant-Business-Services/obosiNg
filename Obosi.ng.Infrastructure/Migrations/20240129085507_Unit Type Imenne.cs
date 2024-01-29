using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UnitTypeImenne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "ImeNne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 55, 7, 80, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.CreateIndex(
                name: "IX_ImeNne_UnitId",
                table: "ImeNne",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImeNne_Unit_UnitId",
                table: "ImeNne",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImeNne_Unit_UnitId",
                table: "ImeNne");

            migrationBuilder.DropIndex(
                name: "IX_ImeNne_UnitId",
                table: "ImeNne");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "ImeNne");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 9, 17, 47, 833, DateTimeKind.Local).AddTicks(7243));
        }
    }
}
