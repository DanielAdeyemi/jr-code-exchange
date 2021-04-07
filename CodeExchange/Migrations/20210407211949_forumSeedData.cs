using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class forumSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "IsVisible", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, false, "Java Sukz", null },
                    { 2, false, "Python Rules", null }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 19, 19, 49, 153, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 14, 19, 49, 153, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 14, 19, 49, 153, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 14, 19, 49, 153, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 14, 19, 49, 153, DateTimeKind.Local).AddTicks(1943));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 17, 1, 0, 459, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 12, 1, 0, 459, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 12, 1, 0, 459, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 12, 1, 0, 459, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 12, 1, 0, 459, DateTimeKind.Local).AddTicks(2454));
        }
    }
}
