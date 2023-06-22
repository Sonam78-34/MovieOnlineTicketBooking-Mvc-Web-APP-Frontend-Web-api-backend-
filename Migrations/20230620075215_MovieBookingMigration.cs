using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieOnlineBooking.Migrations
{
    /// <inheritdoc />
    public partial class MovieBookingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ede59e9-5315-4866-81a1-98c3e24a9cf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906ad84e-ece6-457e-a229-4e7dc2a00cf3");

            migrationBuilder.DropColumn(
                name: "About1",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "About2",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "review1Description1",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "review1Description2",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "review1description3",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "reviewName1",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "reviewName2",
                table: "movies");

            migrationBuilder.RenameColumn(
                name: "reviewName3",
                table: "movies",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0524ea0f-6fb5-4bfa-8f26-424740911ba6", "2", "User", "User" },
                    { "c4ff208a-3eac-46c0-943b-70cdaac27bae", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0524ea0f-6fb5-4bfa-8f26-424740911ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4ff208a-3eac-46c0-943b-70cdaac27bae");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "movies",
                newName: "reviewName3");

            migrationBuilder.AddColumn<string>(
                name: "About1",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "About2",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "review1Description1",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "review1Description2",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "review1description3",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "reviewName1",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "reviewName2",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ede59e9-5315-4866-81a1-98c3e24a9cf7", "2", "User", "User" },
                    { "906ad84e-ece6-457e-a229-4e7dc2a00cf3", "1", "Admin", "Admin" }
                });
        }
    }
}
