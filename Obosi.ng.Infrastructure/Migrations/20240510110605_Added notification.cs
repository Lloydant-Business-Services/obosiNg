using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addednotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 8, 11, 29, 22, 553, DateTimeKind.Local).AddTicks(2222));
        }
    }
}
