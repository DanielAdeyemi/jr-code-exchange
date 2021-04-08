using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class newForumSeedsagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2,
                column: "Name",
                value: "Python Rulez");

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "IsVisible", "Name" },
                values: new object[,]
                {
                    { 3, false, "Pyt Rules" },
                    { 4, false, "Pyhon Rules" },
                    { 5, false, "thon Rules" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 15, 46, 7, 573, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 46, 7, 573, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 46, 7, 573, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 46, 7, 573, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 8, 10, 46, 7, 573, DateTimeKind.Local).AddTicks(1750));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2,
                column: "Name",
                value: "Python Rules");

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
    }
}
