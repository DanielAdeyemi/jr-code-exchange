using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class PostPreviewMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Preview",
                table: "Posts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 15, 43, 3, 565, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 10, 43, 3, 565, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 10, 43, 3, 565, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 10, 43, 3, 565, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 10, 43, 3, 565, DateTimeKind.Local).AddTicks(2938));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preview",
                table: "Posts");

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
    }
}
