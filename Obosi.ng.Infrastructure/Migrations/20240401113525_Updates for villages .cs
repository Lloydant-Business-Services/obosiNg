using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatesforvillages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Village",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Village", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Village_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    VillageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aka_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aka_Village_VillageId",
                        column: x => x.VillageId,
                        principalTable: "Village",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Umunna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    AkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Umunna", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Umunna_Aka_AkaId",
                        column: x => x.AkaId,
                        principalTable: "Aka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Umunna_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imenne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    UmunnaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imenne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imenne_Umunna_UmunnaId",
                        column: x => x.UmunnaId,
                        principalTable: "Umunna",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imenne_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 4, 1, 12, 35, 25, 210, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.CreateIndex(
                name: "IX_Aka_UnitId",
                table: "Aka",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Aka_VillageId",
                table: "Aka",
                column: "VillageId");

            migrationBuilder.CreateIndex(
                name: "IX_Imenne_UmunnaId",
                table: "Imenne",
                column: "UmunnaId");

            migrationBuilder.CreateIndex(
                name: "IX_Imenne_UnitId",
                table: "Imenne",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Umunna_AkaId",
                table: "Umunna",
                column: "AkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Umunna_UnitId",
                table: "Umunna",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Village_UnitId",
                table: "Village",
                column: "UnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imenne");

            migrationBuilder.DropTable(
                name: "Umunna");

            migrationBuilder.DropTable(
                name: "Aka");

            migrationBuilder.DropTable(
                name: "Village");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 26, 12, 56, 0, 844, DateTimeKind.Local).AddTicks(8668));
        }
    }
}
