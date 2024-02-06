using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IImenne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ImeNne_ImeNneId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ImeNne");

            migrationBuilder.DropIndex(
                name: "IX_Users_ImeNneId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImeNneId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Personality",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    PortFolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personality_Users_UserId",
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
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.InsertData(
                table: "Unit_Type",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[] { 13, true, "Ime Nne" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 6, 7, 14, 15, 482, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.CreateIndex(
                name: "IX_Personality_UserId",
                table: "Personality",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personality");

            migrationBuilder.DeleteData(
                table: "Unit_Type",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.AddColumn<int>(
                name: "ImeNneId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ImeNne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImeNne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImeNne_Unit_UnitId",
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
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DateCreated", "ImeNneId" },
                values: new object[] { new DateTime(2024, 2, 5, 13, 10, 40, 788, DateTimeKind.Local).AddTicks(5858), null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ImeNneId",
                table: "Users",
                column: "ImeNneId");

            migrationBuilder.CreateIndex(
                name: "IX_ImeNne_UnitId",
                table: "ImeNne",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ImeNne_ImeNneId",
                table: "Users",
                column: "ImeNneId",
                principalTable: "ImeNne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
