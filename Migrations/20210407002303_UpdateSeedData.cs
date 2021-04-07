using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 22, 23, 2, 599, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 23, 2, 599, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 23, 2, 599, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 23, 2, 599, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 23, 2, 599, DateTimeKind.Local).AddTicks(9045));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5514));
        }
    }
}
