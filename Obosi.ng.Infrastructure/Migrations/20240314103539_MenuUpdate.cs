using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MenuUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuGroupId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_MenuGroup_MenuGroupId",
                        column: x => x.MenuGroupId,
                        principalTable: "MenuGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuInRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuInRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuInRole_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenuInRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 11, 35, 36, 566, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuGroupId",
                table: "Menu",
                column: "MenuGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuInRole_MenuId",
                table: "MenuInRole",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuInRole_RoleId",
                table: "MenuInRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuInRole");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 7, 34, 23, 76, DateTimeKind.Local).AddTicks(1084));
        }
    }
}
