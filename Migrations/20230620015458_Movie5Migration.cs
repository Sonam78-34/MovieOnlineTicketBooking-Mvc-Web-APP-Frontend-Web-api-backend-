using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieOnlineBooking.Migrations
{
    /// <inheritdoc />
    public partial class Movie5Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23bbaa1b-aa71-40b8-ad01-867ffc6fc09e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b38d7913-202e-47cf-bc2f-79c5ea5caed4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b232dfe-13b9-4f0e-b696-2ebec1171679", "2", "User", "User" },
                    { "a5e47926-f6bc-4828-8eb2-668effcf64cb", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b232dfe-13b9-4f0e-b696-2ebec1171679");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e47926-f6bc-4828-8eb2-668effcf64cb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23bbaa1b-aa71-40b8-ad01-867ffc6fc09e", "2", "User", "User" },
                    { "b38d7913-202e-47cf-bc2f-79c5ea5caed4", "1", "Admin", "Admin" }
                });
        }
    }
}
