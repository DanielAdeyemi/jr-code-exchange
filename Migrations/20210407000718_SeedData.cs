using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AppUserId", "AppUserId1", "Content", "CreationDate", "CreatorId", "Dislikes", "IsVisible", "Likes", "PostId1", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, "Python dookie", new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(4875), 1, 0, true, 2, null, "Python Sucks", null },
                    { 2, null, null, "Swift dookie", new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5496), 2, 0, true, 100, null, "Swift Sucks", null },
                    { 3, null, null, "C# dookie", new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5508), 3, 0, true, 3, null, "C# Sucks", null },
                    { 4, null, null, "Java dookie", new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5511), 4, 0, true, 9, null, "Java Sucks", null },
                    { 5, null, null, "JavaScript dookie", new DateTime(2021, 4, 6, 17, 7, 18, 486, DateTimeKind.Local).AddTicks(5514), 1, 10, true, 0, null, "JavaScript Sucks", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);
        }
    }
}
