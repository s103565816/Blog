using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class another : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "TagId");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1105));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "Tags",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 0, 52, 412, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 0, 52, 412, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 12, 0, 52, 412, DateTimeKind.Local).AddTicks(905));
        }
    }
}
