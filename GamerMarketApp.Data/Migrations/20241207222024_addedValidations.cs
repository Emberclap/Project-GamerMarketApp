using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(2100)",
                maxLength: 2100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Games",
                type: "nvarchar(2100)",
                maxLength: 2100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4d3cb23-969b-40ce-a41b-15abd72a6072", "AQAAAAIAAYagAAAAEJnQH9O4Qa69L6UgRx5/Lav8VOnP2x8fNk4YlcqEaoAQ/5qrC3bOuPOHqHgk5PpOaw==", "b554ab40-b1ce-437d-957a-07d60a0ec1ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd214c1d-5c58-4aee-858a-5fbbe1b5a001", "AQAAAAIAAYagAAAAECRJyMMe69CUCTLAwv1aDen9Z0jVHny+/qOWdJQUBJbC5Iu0NvvkPxpc0nmI5QAM4A==", "de4b6645-3420-45d7-9dfc-7fbda7cd01a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c07341-f610-4e1a-82af-792644004c7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d5c137-480a-4f8f-a2b8-0296c5c07b05", "AQAAAAIAAYagAAAAEArjZzYCV5v9BLlLYeFiARYW99UBUV6Y1oWuRL86foiuOBAEHgDz2HgaAx9xXhlmKA==", "81b00551-c9ff-4405-8e41-e1bef8d6104e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc8270d3-0550-4df0-8de5-c9ed6dacdb04", "AQAAAAIAAYagAAAAEDaLiXcY4Ini2ia+h3BEBhMJIVVT493xz5aAQVJMlPt1YuHMNpUSeQb02x6ormXfGQ==", "960a1846-e492-4f0b-add5-6ec7fcf81b76" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2100)",
                oldMaxLength: 2100);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2100)",
                oldMaxLength: 2100,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "3", null, "IdentityRole", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df87c82b-767c-4ef3-9e95-73ffb62cd79a", "AQAAAAIAAYagAAAAEIuG7+zjv7s9t1mEkUe3Q0KWD62E7uIB4njzz/Q/3UEdsEfpayXKpzjBBIw6xiPZag==", "7581afc6-a454-4d64-a3f6-956d8ec4b3ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba1377b-78bb-4d2d-a12c-283772269087", "AQAAAAIAAYagAAAAEOHRaHt7jQuBLMuKWYeiWiv3Qdx17TSdHzoskpge/nlDxkV8QwcrHvXQfo3mn6Yyxw==", "ecd9c1a2-5d7e-4ffa-bf39-d87f54084b98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c07341-f610-4e1a-82af-792644004c7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fbe6f62-0485-4dab-b9a9-9fe507de8230", "AQAAAAIAAYagAAAAENFLeakPqrnaQRs7gkJbRoKXzHyKnlFF0C/e6bca35r2RXXnEu+plZgF84KJ2PJW8w==", "d41f01d1-bfae-41cc-a044-f604b9d1d1af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "940bb2dc-eb05-4113-9d72-0b7441535b20", "AQAAAAIAAYagAAAAEEop9awX60gPQQFW6IkJ1WI1l9AOexwyJJJ2uh5ih3VxediWS+BbHBAlaC7TFwiiXA==", "5f3c1fc4-71db-498a-97f0-6e28b0979889" });

        }
    }
}
