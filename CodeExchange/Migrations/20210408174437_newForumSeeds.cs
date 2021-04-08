using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class newForumSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 15, 44, 36, 797, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 44, 36, 797, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 44, 36, 797, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 44, 36, 797, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 44, 36, 797, DateTimeKind.Local).AddTicks(6178));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 5, 5, 29, 319, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3904));
        }
    }
}
