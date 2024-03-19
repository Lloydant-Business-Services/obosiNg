using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 12, 40, 58, 49, DateTimeKind.Local).AddTicks(290));
        }
    }
}
