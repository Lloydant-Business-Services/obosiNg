using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedAboutentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 17, 17, 25, 36, 470, DateTimeKind.Local).AddTicks(7034));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "About");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "About");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 16, 45, 38, 836, DateTimeKind.Local).AddTicks(3157));
        }
    }
}
