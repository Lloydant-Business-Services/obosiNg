using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class postlikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostLikes_Users_UserId",
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
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 30, 6, 56, 35, 582, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId",
                table: "PostLikes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_UserId",
                table: "PostLikes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 5, 29, 11, 8, 53, 506, DateTimeKind.Local).AddTicks(7972));
        }
    }
}
