using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class UpdateSeedCreators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 21, 34, 21, 48, DateTimeKind.Local).AddTicks(9557), "Uncle Daniel" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(41), "Uncle Tien" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(49), "Uncle Mikey" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(57), "John" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(64), "Lol2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 21, 28, 17, 454, DateTimeKind.Local).AddTicks(5105), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 28, 17, 454, DateTimeKind.Local).AddTicks(5635), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 28, 17, 454, DateTimeKind.Local).AddTicks(5644), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 28, 17, 454, DateTimeKind.Local).AddTicks(5650), null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "CreationDate", "Creator" },
                values: new object[] { new DateTime(2021, 4, 7, 16, 28, 17, 454, DateTimeKind.Local).AddTicks(5657), null });
        }
    }
}
