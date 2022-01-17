using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3f5f3d8-b996-4559-b298-bba8a3d3b834", "2a054e93-54e7-42cc-bf7e-03132257c11f", "Administrator", "ADMINISTRATOR" },
                    { "db4c66dc-d514-496a-abef-43658d210d85", "527bd130-789f-4c26-b8f3-2470a14b09a6", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bd15738-a851-4887-b718-ce644fda4044", 0, "a91a8397-6fbb-4ca2-ab14-07f0bdbb3e7b", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEOXX+Wh22aku64HL3t++j3GsrIAUJomxU/d+2EH6aYyCrvNRVrTmwNjXa1lIkMKExw==", null, false, "9ab75bae-8286-4bd3-8af0-497143f44bac", false, "user@bookstore.com" },
                    { "5c56642b-c280-4f12-8544-c208ec784f0b", 0, "ee140014-6eef-41b6-b8bc-1ffcc4b3bfd5", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEDyDgf1RK+grSgdd2hU/R0qTJk1ba0/3AMP2uILeCTPj0Be58C8fByJVVy1PSqLtMQ==", null, false, "aa9719e3-3bfb-45db-b687-2c4a0c727186", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "db4c66dc-d514-496a-abef-43658d210d85", "1bd15738-a851-4887-b718-ce644fda4044" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b3f5f3d8-b996-4559-b298-bba8a3d3b834", "5c56642b-c280-4f12-8544-c208ec784f0b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db4c66dc-d514-496a-abef-43658d210d85", "1bd15738-a851-4887-b718-ce644fda4044" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3f5f3d8-b996-4559-b298-bba8a3d3b834", "5c56642b-c280-4f12-8544-c208ec784f0b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3f5f3d8-b996-4559-b298-bba8a3d3b834");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db4c66dc-d514-496a-abef-43658d210d85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bd15738-a851-4887-b718-ce644fda4044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c56642b-c280-4f12-8544-c208ec784f0b");
        }
    }
}
