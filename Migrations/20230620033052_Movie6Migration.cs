using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieOnlineBooking.Migrations
{
    /// <inheritdoc />
    public partial class Movie6Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0ede59e9-5315-4866-81a1-98c3e24a9cf7", "2", "User", "User" },
                    { "906ad84e-ece6-457e-a229-4e7dc2a00cf3", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ede59e9-5315-4866-81a1-98c3e24a9cf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906ad84e-ece6-457e-a229-4e7dc2a00cf3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b232dfe-13b9-4f0e-b696-2ebec1171679", "2", "User", "User" },
                    { "a5e47926-f6bc-4828-8eb2-668effcf64cb", "1", "Admin", "Admin" }
                });
        }
    }
}
