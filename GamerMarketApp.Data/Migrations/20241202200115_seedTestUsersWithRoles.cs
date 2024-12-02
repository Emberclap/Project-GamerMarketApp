using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedTestUsersWithRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", null, "MANAGER", "MANAGER" },
                    { "3", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b2672b21-456d-4205-9f1f-0b8b619c83c4", "admin@gmail.com", "ADMIN@GMAIL.COM", "TESTADMIN", "AQAAAAIAAYagAAAAEMjawoAS42P5hMncS8G9cHfv1HM5ysoue0tgEzyi7DetlQd4HIpHDhANWvT4aKpCKQ==", "7a38c900-4d0f-448d-99dc-76c8e7baeafa", "testAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11b7f420-600c-4095-926f-677202d4235f", 0, "6b648811-9607-4416-9ed8-155a202713ef", "TESTUSER@GMAIL.COM", true, false, null, "TESTUSER@GMAIL.COM", "TESTUSER", "AQAAAAIAAYagAAAAEOcSzBg7rY3kFFTYEuHR4Q/9pTFAgRUQZJVwyFD+xdKwVC5fD23GP+omt06zPUNjdg==", null, false, "89b2d5d7-30b3-4cad-acdf-d4650e8749dc", false, "testUser" },
                    { "edd0d843-08a0-40d8-99f3-89414603ae15", 0, "4d5ba15d-bf01-48f1-b5e0-01c0d9615134", "Manager@GMAIL.COM", true, false, null, "MANAGER@GMAIL.COM", "TESTMANAGER", "AQAAAAIAAYagAAAAEL6kqshHbwqRZc/OpGjlKQMnMGTgeAaNARWevsrcSmg15bh7OhbjKjY/zBaFTUZkBg==", null, false, "ceab3a3a-5324-4025-8175-d2115bff7ba1", false, "testManager" }
                });

           
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "11b7f420-600c-4095-926f-677202d4235f" },
                    { "2", "edd0d843-08a0-40d8-99f3-89414603ae15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "edd0d843-08a0-40d8-99f3-89414603ae15" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b80bae2-64a1-492d-85ed-8cc426d0b341", "admin@example.com", "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF6MArzVR2cY/yANjQ7OFiJbXVTn9oOObQoO0JDmOqlhQpYOW7nv9w7+PF6F09XsIA==", "9e06e609-8f14-4a31-a713-200c74f124b8", "admin@example.com" });

        }
    }
}
