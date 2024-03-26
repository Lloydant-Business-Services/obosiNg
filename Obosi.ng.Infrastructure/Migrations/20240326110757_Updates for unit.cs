using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatesforunit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitAdmin_Unit_UnitId1",
                table: "UnitAdmin");

            migrationBuilder.DropIndex(
                name: "IX_UnitAdmin_UnitId1",
                table: "UnitAdmin");

            migrationBuilder.DropColumn(
                name: "UnitId1",
                table: "UnitAdmin");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "UnitAdmin",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 7, 56, 985, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.CreateIndex(
                name: "IX_UnitAdmin_UnitId",
                table: "UnitAdmin",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitAdmin_Unit_UnitId",
                table: "UnitAdmin",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnitAdmin_Unit_UnitId",
                table: "UnitAdmin");

            migrationBuilder.DropIndex(
                name: "IX_UnitAdmin_UnitId",
                table: "UnitAdmin");

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "UnitAdmin",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UnitId1",
                table: "UnitAdmin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 9, 26, 43, 665, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.CreateIndex(
                name: "IX_UnitAdmin_UnitId1",
                table: "UnitAdmin",
                column: "UnitId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UnitAdmin_Unit_UnitId1",
                table: "UnitAdmin",
                column: "UnitId1",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
