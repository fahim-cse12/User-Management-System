using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class initiate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0bf8da0e-9ed1-4366-8bb3-49807e83fc95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58c62940-8827-451e-9d87-b2ea80db21e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6328357d-67b1-44b2-b9f4-5ba6810e267c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "089d4397-0f89-44b5-9393-aac493e4694f", "3", "HR", "HR" },
                    { "0edfa5a5-475b-4cd8-93ac-9808f31b70ad", "1", "Admin", "Admin" },
                    { "57cf8ed5-5991-4de1-924d-b3d7c336b036", "2", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "089d4397-0f89-44b5-9393-aac493e4694f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0edfa5a5-475b-4cd8-93ac-9808f31b70ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57cf8ed5-5991-4de1-924d-b3d7c336b036");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bf8da0e-9ed1-4366-8bb3-49807e83fc95", "1", "Admin", "Admin" },
                    { "58c62940-8827-451e-9d87-b2ea80db21e9", "3", "HR", "HR" },
                    { "6328357d-67b1-44b2-b9f4-5ba6810e267c", "2", "User", "User" }
                });
        }
    }
}
