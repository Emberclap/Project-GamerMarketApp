using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameManagerRoleAndMoreItemsSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "Manager");

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
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9fff2ba-f7f1-492c-a78e-4bc2005ce3eb", "AQAAAAIAAYagAAAAEDxa+8cPKDPGmIZiPL7J9yV4m69q5ViMKcWmbLS5M+dCtRZ8aQAJhChbgFW/6k/Esw==", "f766e524-d9d9-466c-98c8-e0dcaabdb464" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5c07341-f610-4e1a-82af-792644004c7e", 3, "50c81c60-1a66-4f21-a7eb-cfdcbf28e729", "user2@gmail.com", true, true, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAEGMfpsBzPGssUtbQRAUWV5BrYL0+p4nFPnMN7Z2Au9pIZbW5oqFqD6grMsL2jQ+M9g==", null, false, "2d79c0d4-0746-40f3-919d-18507eee1df5", false, "User2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.9m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 333.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 66.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2599.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 444.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.99m, "11b7f420-600c-4095-926f-677202d4235f" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AddedOn", "Description", "GameId", "ImageUrl", "IsDeleted", "Name", "Price", "PublisherId", "SubtypeId" },
                values: new object[,]
                {
                    { 11, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rare arcana skin for Pudge, featuring stunning visual effects.", 2, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f", false, "Feast of Abscession", 22.9m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 12, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary knife skin for CS:GO with sleek animations and rare patterns.", 1, "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg", false, "Karambit", 199.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 13, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic astronaut-themed skin for Fortnite, perfect for galactic explorers.", 3, "https://qudahalloween.com/cdn/shop/articles/Dark-Voyager-costume-featured_1201x.jpg?v=1719395076", false, "Dark Voyager", 14.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 14, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dynamic skin for Lux that changes elements during the match.", 6, "https://i.pinimg.com/originals/f8/31/92/f83192912b8b605cc046810c47e9b8e7.jpg", false, "Elementalist Lux", 24.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 15, new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rare arcana skin for Pudge, featuring stunning visual effects.", 2, "https://dota-showcase.com/storage/econ/items/phantom_assassin/manifold_paradox/arcana_pa_style2.png", false, "Manifold Paradox", 19.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 16, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The fabled blades that shattered the Anvil Magus Hroth. Its terrible weight dented and shattered his iron shell, just as its blades tore into the enchanted hide beneath.", 2, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXB9AJbIo8h5hlcX0TVVduv287XVk5LJxFZsragejhs0uHPdHMXuIzgwtaIk6_wMuvUwDoF7pJ12-_D8Ijw0FG1-UVpMTr2LYGQdVA2fxiOrTHuJria/360fx360f", false, "Inscribed The Basher Blades", 6.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 17, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "High risk and high reward, the infamous AWP is recognizable by its signature report and one-shot, one-kill policy. It has been painted by airbrushing transparent paints that fade together over a chrome base coat. This isn't just a weapon, it's a conversation piece - Imogen, Arms Dealer In Training", 1, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAZh7PLfYQJE7dizq4yCkP_gfezXxj0IvJBy2rrH9NSh2VXs80VsYWGnd9SWcAFoaFCEqVa7wu3oh5Gi_MOeScxOzqI/360fx360f", false, "AWP | Fade", 1799.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 7 },
                    { 18, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A unique skin for Wraith that delves into her mysterious past.", 13, "https://cdnb.artstation.com/p/assets/images/images/027/923/487/4k/gary-huang-voidwalker-master.jpg?1592962782", false, "Wraith Voidwalker", 11.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 1 },
                    { 19, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "An ultra-rare mount with a ghostly tiger aesthetic.", 4, "https://wow.zamimg.com/uploads/screenshots/normal/1079770-reins-of-the-swift-spectral-tiger.jpg", false, "Swift Spectral Tiger", 499.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 6 },
                    { 20, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brutosaurs are used by the Zandalari Empire as both weapons of war and enormous, mobile trading posts.", 4, "https://wow.zamimg.com/uploads/screenshots/normal/742674-reins-of-the-mighty-caravan-brutosaur.jpg", false, "Reins of the Mighty Caravan Brutosaur", 290.99m, "d5c07341-f610-4e1a-82af-792644004c7e", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5c07341-f610-4e1a-82af-792644004c7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "Name",
                value: "MANAGER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b7f420-600c-4095-926f-677202d4235f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca1750d7-a6d8-45aa-9a06-b7189b747ee5", "AQAAAAIAAYagAAAAEKjOf8nxBBAElvGkEu2VMTn+yl7ntHHEWmV3ta44F8yLyL275ii47GoR1C7sB2iE+A==", "7062fce8-82b8-4584-8fa8-05ddd7319373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb1d6da-acfe-4f39-a852-4438ef045e8e", "AQAAAAIAAYagAAAAEE+QRGHM2nclEKo8YsF49X85NLnzhiziVluVpvUO+Uji5jLG7FB5S4KlGMR9axI+RA==", "ef7a5a60-52b1-4b4e-a380-8cd3c4dde96f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd0d843-08a0-40d8-99f3-89414603ae15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13edec63-ab04-4b7c-af83-0d63aadb4b8a", "AQAAAAIAAYagAAAAEEIsAfny2V8Co6j81tovxivQjnMkpRtkdX6+AKd+aPY0nvF3b9Q1f6GYgUm3dIxnaQ==", "b313c21e-2ce7-4d8f-8aec-8fad58acc682" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.9m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 199.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1799.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 499.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "AddedOn", "Price", "PublisherId" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 290.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" });
        }
    }
}
