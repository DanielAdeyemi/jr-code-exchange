using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class UpdateForumSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 1,
                column: "Name",
                value: "Strata");

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2,
                column: "Name",
                value: "C#");

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "ForumId", "IsVisible", "Name" },
                values: new object[,]
                {
                    { 27, false, "Show Case" },
                    { 26, false, "Jobhunting" },
                    { 25, false, "JavaScript" },
                    { 24, false, "PowerShell" },
                    { 23, false, "BASH" },
                    { 22, false, "HTML" },
                    { 21, false, "XML" },
                    { 20, false, "Visual Basic" },
                    { 19, false, "SQL Lite" },
                    { 18, false, "SQL" },
                    { 17, false, "Swift" },
                    { 16, false, "Objective-C" },
                    { 14, false, "Go" },
                    { 13, false, "F#" },
                    { 12, false, "COBOL" },
                    { 11, false, "Assembly" },
                    { 10, false, "C" },
                    { 8, false, "CSS" },
                    { 7, false, "C++" },
                    { 6, false, "C#" },
                    { 5, false, "Java" },
                    { 4, false, "Ruby" },
                    { 15, false, "MySQL" },
                    { 3, false, "Python" }
                });
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

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 1,
                column: "Name",
                value: "Java Sukz");

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "ForumId",
                keyValue: 2,
                column: "Name",
                value: "Python Rules");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "AppUserId", "AppUserId1", "Content", "CreationDate", "Creator", "CreatorId", "Dislikes", "IsVisible", "Likes", "PostId1", "Preview", "Title" },
                values: new object[,]
                {
                    { 1, null, null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2021, 4, 8, 5, 5, 29, 319, DateTimeKind.Local).AddTicks(3651), "Uncle Daniel", 1, 0, true, 2, null, null, "Python Sucks" },
                    { 2, null, null, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure", new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3888), "Uncle Tien", 2, 0, true, 100, null, null, "Swift Sucks" },
                    { 3, null, null, "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain.", new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3893), "Uncle Mikey", 3, 0, true, 3, null, null, "C# Sucks" },
                    { 4, null, null, "Here's a post", new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3899), "John", 4, 0, true, 9, null, null, "Java Sucks" },
                    { 5, null, null, "I would upload an image here if I had that functionality", new DateTime(2021, 4, 8, 0, 5, 29, 319, DateTimeKind.Local).AddTicks(3904), "Lol2", 1, 10, true, 0, null, null, "JavaScript Sucks" }
                });
        }
    }
}
