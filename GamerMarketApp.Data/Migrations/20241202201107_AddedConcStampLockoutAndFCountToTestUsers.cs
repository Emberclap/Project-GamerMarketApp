using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedConcStampLockoutAndFCountToTestUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "fb49e91d-56e7-4fa5-ab1c-592d0bd303bc", true, "AQAAAAIAAYagAAAAEE7vns5CJnwIl65AfbpumYRaS9AWpryeRWqOmz/+MkcwwDlcvG8dPFdc7dM/xb2oFw==", "930be914-7c72-4472-9a06-dcf740adc7d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "8eb90964-6497-4e8c-a661-88951fe12a63", true, "AQAAAAIAAYagAAAAEN/RvNwZ+QU+n+nRlnMb04Jdsu49FAFGr+PRQ+H4vjlPHWQKf5FJZbV1i+YbqO2Z2A==", "0e674ea2-2818-4dee-8a8c-bd322e400c5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 3, "254348a1-36cb-4ed1-a0ff-98690eeb14ca", true, "AQAAAAIAAYagAAAAEGp+/9bqibaEqXVdza4kWwoYcWlNy4O2woRkBjQlQcjOU20OhPuZxPk5/3BOSFrtDA==", "9bfe205f-7fdf-4cfd-b7f8-b13c5bfa9b84" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "6b648811-9607-4416-9ed8-155a202713ef", false, "AQAAAAIAAYagAAAAEOcSzBg7rY3kFFTYEuHR4Q/9pTFAgRUQZJVwyFD+xdKwVC5fD23GP+omt06zPUNjdg==", "89b2d5d7-30b3-4cad-acdf-d4650e8749dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "b2672b21-456d-4205-9f1f-0b8b619c83c4", false, "AQAAAAIAAYagAAAAEMjawoAS42P5hMncS8G9cHfv1HM5ysoue0tgEzyi7DetlQd4HIpHDhANWvT4aKpCKQ==", "7a38c900-4d0f-448d-99dc-76c8e7baeafa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "4d5ba15d-bf01-48f1-b5e0-01c0d9615134", false, "AQAAAAIAAYagAAAAEL6kqshHbwqRZc/OpGjlKQMnMGTgeAaNARWevsrcSmg15bh7OhbjKjY/zBaFTUZkBg==", "ceab3a3a-5324-4025-8175-d2115bff7ba1" });

        }
    }
}
