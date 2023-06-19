using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class RoleData_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
