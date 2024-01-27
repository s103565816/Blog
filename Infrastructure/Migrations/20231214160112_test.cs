using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3347), "A very interesting post" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3356), "A very interesting post" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3358), "A very interesting post" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1083), "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1103), "" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "DatePublished", "PostContent" },
                values: new object[] { new DateTime(2023, 12, 14, 12, 19, 40, 111, DateTimeKind.Local).AddTicks(1105), "" });
        }
    }
}
