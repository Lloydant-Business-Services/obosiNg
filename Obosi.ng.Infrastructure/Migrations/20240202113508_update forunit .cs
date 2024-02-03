using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obosi.ng.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateforunit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanHaveMembers",
                table: "Unit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CanHaveMembers", "DateCreated" },
                values: new object[] { false, new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 12, 35, 8, 218, DateTimeKind.Local).AddTicks(1495));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanHaveMembers",
                table: "Unit");

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Unit",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2024, 1, 29, 14, 42, 4, 955, DateTimeKind.Local).AddTicks(6053));
        }
    }
}
