using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieOnlineBooking.Migrations
{
    /// <inheritdoc />
    public partial class Movie4Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba364242-ac31-496c-a5b3-c1e731e0a12a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b49e06-d8a0-4210-9f0e-181c619f554b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23bbaa1b-aa71-40b8-ad01-867ffc6fc09e", "2", "User", "User" },
                    { "b38d7913-202e-47cf-bc2f-79c5ea5caed4", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "ba364242-ac31-496c-a5b3-c1e731e0a12a", "1", "Admin", "Admin" },
                    { "f0b49e06-d8a0-4210-9f0e-181c619f554b", "2", "User", "User" }
                });
        }
    }
}
