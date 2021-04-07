using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExchange.Migrations
{
    public partial class UpdateSeededProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 16, 57, 52, 228, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 57, 52, 228, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 57, 52, 228, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 57, 52, 228, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 57, 52, 228, DateTimeKind.Local).AddTicks(752));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 16, 44, 29, 402, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 44, 29, 402, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 44, 29, 402, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 44, 29, 402, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2021, 4, 7, 11, 44, 29, 402, DateTimeKind.Local).AddTicks(6037));
        }
    }
}
