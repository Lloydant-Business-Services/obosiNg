using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class unitadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Unit_UnitId1",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_UnitId1",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UnitId1",
                table: "Post");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "Post",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 24, 11, 56, 11, 273, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.CreateIndex(
                name: "IX_Post_UnitId",
                table: "Post",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Unit_UnitId",
                table: "Post",
                column: "UnitId",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Unit_UnitId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_UnitId",
                table: "Post");

            migrationBuilder.AlterColumn<long>(
                name: "UnitId",
                table: "Post",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitId1",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 10, 12, 6, 5, 183, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.CreateIndex(
                name: "IX_Post_UnitId1",
                table: "Post",
                column: "UnitId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Unit_UnitId1",
                table: "Post",
                column: "UnitId1",
                principalTable: "Unit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
