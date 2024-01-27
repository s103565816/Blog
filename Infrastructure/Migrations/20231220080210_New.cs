using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2023, 12, 20, 15, 2, 10, 385, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2023, 12, 20, 15, 2, 10, 385, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2023, 12, 20, 15, 2, 10, 385, DateTimeKind.Local).AddTicks(7181));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "DatePublished",
                value: new DateTime(2023, 12, 14, 23, 1, 12, 296, DateTimeKind.Local).AddTicks(3358));
        }
    }
}
