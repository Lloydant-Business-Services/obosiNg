using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addforumsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGeneral",
                table: "Forum",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Forum",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 13, 14, 17, 141, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.CreateIndex(
                name: "IX_Forum_UnitId",
                table: "Forum",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forum_Unit_UnitId",
                table: "Forum",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forum_Unit_UnitId",
                table: "Forum");

            migrationBuilder.DropIndex(
                name: "IX_Forum_UnitId",
                table: "Forum");

            migrationBuilder.DropColumn(
                name: "IsGeneral",
                table: "Forum");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Forum");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 6, 11, 12, 32, 18, 822, DateTimeKind.Local).AddTicks(2683));
        }
    }
}
