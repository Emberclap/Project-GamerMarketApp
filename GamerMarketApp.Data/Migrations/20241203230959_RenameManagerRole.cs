using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameManagerRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45019118-5620-4264-ba74-893082bbfd36", "AQAAAAIAAYagAAAAEFIpWqA5+kJRSl8PRizPE+MSP1hVw8g8rCNgq7T0tT443WExmnFGT5L/WnAy2hG+nw==", "36e8ead9-fb3a-4b66-aa97-d08d39f4c261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2c68c1c-1a78-4d62-94df-8f4ed5b083a8", "AQAAAAIAAYagAAAAEC+EOWCX0zwLzdQUf2CDKi6LqBrTqWOeagjbxEp6yCjoF6ahRqOYFwOm4gJJ9DwZ0w==", "3421b3cd-b642-45d8-abd9-1e27c623fae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c07341-f610-4e1a-82af-792644004c7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7bef1d4-819a-418d-8f62-fb058265b5ac", "AQAAAAIAAYagAAAAEKfQbAIhcqoxXpA2yOlaHW6ku3p5xeGXJ/6WV2Bre9plvZT8gT/SFTP4owWCwIe5TQ==", "964b9de0-1daa-45f8-b15c-82217e124649" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4504fb7e-3b97-4c72-8714-9e026ee44152", "Moderator@gmail.com", "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAIAAYagAAAAELd1ycqDuAVnzfZeqZXz/BxG1gvJ8v+kAMwTcTMejbnpaL+v7zhUaX8wbou//PHYjQ==", "b028491d-ef98-4ff6-a3f2-067503f0e1dc", "Moderator" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c94acd62-3580-4116-b492-084943d54871", "AQAAAAIAAYagAAAAEJnCVjokBvl3iinkpjuH8fFqRGaBNrcO/zYRtAsITRYuPaVk8SlIVpEse38ApYvdHg==", "d61030a0-f500-487b-bc3e-4081cabc4b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa21ec12-8511-4709-bbe8-4168f54e48b3", "AQAAAAIAAYagAAAAEO7Y4EctYM0ebG6uQa5OlbUF6Z56dcoyyQbcgLeCICamayJLqAaN9WwOs6v1I4H1cw==", "9abf624d-9f7a-4c8a-8967-8eb70335ca43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c07341-f610-4e1a-82af-792644004c7e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50c81c60-1a66-4f21-a7eb-cfdcbf28e729", "AQAAAAIAAYagAAAAEGMfpsBzPGssUtbQRAUWV5BrYL0+p4nFPnMN7Z2Au9pIZbW5oqFqD6grMsL2jQ+M9g==", "2d79c0d4-0746-40f3-919d-18507eee1df5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c9fff2ba-f7f1-492c-a78e-4bc2005ce3eb", "manager@gmail.com", "MANAGER@GMAIL.COM", "MANAGER", "AQAAAAIAAYagAAAAEDxa+8cPKDPGmIZiPL7J9yV4m69q5ViMKcWmbLS5M+dCtRZ8aQAJhChbgFW/6k/Esw==", "f766e524-d9d9-466c-98c8-e0dcaabdb464", "Manager" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
