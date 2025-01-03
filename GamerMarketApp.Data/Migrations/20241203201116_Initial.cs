﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubtypes",
                columns: table => new
                {
                    SubtypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubtypes", x => x.SubtypeId);
                    table.ForeignKey(
                        name: "FK_ItemSubtypes_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubtypeId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ItemSubtypes_SubtypeId",
                        column: x => x.SubtypeId,
                        principalTable: "ItemSubtypes",
                        principalColumn: "SubtypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersItems", x => new { x.ItemId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "IdentityRole", "Admin", "ADMIN" },
                    { "2", null, "IdentityRole", "MANAGER", "MANAGER" },
                    { "3", null, "IdentityRole", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11b7f420-600c-4095-926f-677202d4235f", 3, "ca1750d7-a6d8-45aa-9a06-b7189b747ee5", "user@gmail.com", true, true, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEKjOf8nxBBAElvGkEu2VMTn+yl7ntHHEWmV3ta44F8yLyL275ii47GoR1C7sB2iE+A==", null, false, "7062fce8-82b8-4584-8fa8-05ddd7319373", false, "User" },
                    { "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 3, "cfb1d6da-acfe-4f39-a852-4438ef045e8e", "admin@gmail.com", true, true, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEE+QRGHM2nclEKo8YsF49X85NLnzhiziVluVpvUO+Uji5jLG7FB5S4KlGMR9axI+RA==", null, false, "ef7a5a60-52b1-4b4e-a380-8cd3c4dde96f", false, "Admin" },
                    { "edd0d843-08a0-40d8-99f3-89414603ae15", 3, "13edec63-ab04-4b7c-af83-0d63aadb4b8a", "manager@gmail.com", true, true, null, "MANAGER@GMAIL.COM", "MANAGER", "AQAAAAIAAYagAAAAEEIsAfny2V8Co6j81tovxivQjnMkpRtkdX6+AKd+aPY0nvF3b9Q1f6GYgUm3dIxnaQ==", null, false, "b313c21e-2ce7-4d8f-8aec-8fad58acc682", false, "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Fighting" },
                    { 4, "Sports" },
                    { 5, "Racing" },
                    { 6, "RPG" },
                    { 7, "Survival" },
                    { 8, "MMORPG" },
                    { 9, "MOBA" },
                    { 10, "FPS" },
                    { 11, "Shooter" },
                    { 12, "Strategy" },
                    { 13, "Music video game" },
                    { 14, "Battle royale" },
                    { 15, "Sandbox" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ItemTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Cosmetic Items" },
                    { 2, "Functional Equipment" },
                    { 3, "Consumables" },
                    { 4, "Crafting Materials" },
                    { 5, "Currency" },
                    { 6, "Collectibles" },
                    { 7, "Utility Items" },
                    { 8, "Housing and Decor Items" },
                    { 9, "Event-Specific Items" },
                    { 10, "NFTs (Non-Fungible Tokens)" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "11b7f420-600c-4095-926f-677202d4235f" },
                    { "1", "a75b8366-0bac-46e0-9e94-e9cfaf771b3d" },
                    { "2", "edd0d843-08a0-40d8-99f3-89414603ae15" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Description", "GenreId", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, "A competitive first-person shooter where players join terrorists or counter-terrorists in objective-based matches. It features a massive trading market for weapon skins.", 4, "https://cdn.akamai.steamstatic.com/steam/apps/730/header.jpg", false, "Counter-Strike: 2" },
                    { 2, "A team-based MOBA game where two teams of five players control heroes with unique abilities to destroy the enemy's base, featuring a robust economy for hero cosmetics.", 9, "https://cdn.akamai.steamstatic.com/steam/apps/570/header.jpg", false, "Dota 2" },
                    { 3, "A vibrant battle royale game with a unique building mechanic. Players compete to survive, featuring purchasable character skins, emotes, and accessories.", 14, "https://image.api.playstation.com/vulcan/ap/rnd/202410/2918/95953c3726f54fba5e6cf53f97b10bcf99e0d43581ae2c55.jpg", false, "Fortnite" },
                    { 4, "A genre-defining MMORPG where players explore Azeroth, completing quests and engaging in battles. Offers tradable mounts, pets, and unique cosmetic items.", 8, "https://bnetcmsus-a.akamaihd.net/cms/blog_header/h9/H9LLMU20DQFJ1725400142786.png", false, "World of Warcraft" },
                    { 5, "A classic team-based shooter featuring various character classes. Players trade cosmetic hats, weapons, and items to customize their experience.", 10, "https://cdn.cloudflare.steamstatic.com/steam/apps/440/header.jpg", false, "Team Fortress 2" },
                    { 6, "A fast-paced strategy game where two teams of champions compete to destroy each other's nexus. Players can purchase skins and accessories to personalize their gameplay.", 9, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg", false, "League of Legends" },
                    { 7, "A brutal survival game where players gather resources, build bases, and fend off others. Skins for tools and clothing can be bought and traded.", 7, "https://cdn.cloudflare.steamstatic.com/steam/apps/252490/header.jpg", false, "Rust" },
                    { 8, "A realistic battle royale game where players fight to survive in large, detailed maps. It features purchasable and tradable weapon skins and outfits.", 14, "https://cdn.cloudflare.steamstatic.com/steam/apps/578080/header.jpg", false, "PUBG: Battlegrounds" },
                    { 9, "A creative gaming platform where users can design and play games. Features an expansive marketplace for user-created items and skins.", 15, "https://assets-prd.ignimgs.com/2024/09/06/roblox-rdc2024-everythingannounced-blogroll-1725644096329.jpg", false, "Roblox" },
                    { 10, "A high-intensity battle royale with tactical gunfights and squad dynamics. Includes purchasable weapon blueprints, operator skins, and bundles.", 14, "https://shared.cloudflare.steamstatic.com/store_item_assets/steam/apps/1962663/header.jpg?t=1731603761", false, "Call of Duty: Warzone" },
                    { 11, "A space-based MMORPG where players engage in trading, exploration, and massive battles. Features a player-driven economy with tradable ships and skins.", 8, "https://cdn2.unrealengine.com/eve-online-1920x1080-63abdd7114f4.png", false, "EVE Online" },
                    { 12, "An MMORPG set in the rich Elder Scrolls universe, featuring expansive quests and dungeons. Players can buy mounts, costumes, and furnishings.", 8, "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/306130/header.jpg?t=1726169108", false, "The Elder Scrolls Online" },
                    { 13, "A fast-paced battle royale with unique hero abilities. Features a variety of skins and cosmetics available for purchase.", 14, "https://cdn.cloudflare.steamstatic.com/steam/apps/1172470/header.jpg", false, "Apex Legends" },
                    { 14, "A sandbox game where players can build, mine, and explore an infinite world. Offers a marketplace for skins, texture packs, and other in-game content.", 15, "https://i.ytimg.com/vi_webp/ztNoBI0m_P0/maxresdefault.webp", false, "Minecraft" }
                });

            migrationBuilder.InsertData(
                table: "ItemSubtypes",
                columns: new[] { "SubtypeId", "Description", "ItemTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Custom appearances for characters, weapons, or vehicles.", 1, "Skins" },
                    { 2, "Decorative headgear for characters.", 1, "Hats/Helmets" },
                    { 3, "Custom animations for characters, such as dances or gestures.", 1, "Emotes/Dances" },
                    { 4, "Customizable graffiti or tags used in-game.", 1, "Sprays" },
                    { 5, "Companion creatures that follow the player.", 1, "Pets" },
                    { 6, "Vehicles or creatures used for faster travel or aesthetics.", 1, "Mounts" },
                    { 7, "Guns, swords, or other items used in combat.", 2, "Weapons" },
                    { 8, "Gear providing protection or stat boosts.", 2, "Armor" },
                    { 9, "Transport or combat vehicles, often tradable.", 2, "Vehicles" },
                    { 10, "Items that restore health points (HP).", 3, "Health Potions" },
                    { 11, "Temporary stat-boosting consumables.", 3, "Buffs" },
                    { 12, "Items that resurrect players or allies.", 3, "Revival Items" },
                    { 13, "Materials used for crafting weapons or armor.", 4, "Ores/Metals" },
                    { 14, "Ingredients used for alchemy or potion-making.", 4, "Herbs" },
                    { 15, "Instructions for crafting specific items.", 4, "Blueprints/Recipes" },
                    { 16, "In-game standard currency for trading.", 5, "Gold/Coins" },
                    { 17, "Real-money currency for in-game purchases.", 5, "Premium Currency" },
                    { 18, "Containers with random rewards.", 5, "Loot Boxes/Crates" },
                    { 19, "Digital or physical cards collected by players.", 6, "Trading Cards" },
                    { 20, "Items that expand player inventory space.", 7, "Bags/Inventory Space" },
                    { 21, "Items for decorating player-owned spaces.", 8, "Furniture" },
                    { 22, "Customizable decorations for in-game housing.", 8, "Wall Art" },
                    { 23, "Limited-time skins available during events.", 9, "Holiday-Themed Skins" },
                    { 24, "Unique, tradable assets tied to blockchain technology.", 10, "Blockchain-Based Assets" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AddedOn", "Description", "GameId", "ImageUrl", "IsDeleted", "Name", "Price", "PublisherId", "SubtypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rare arcana skin for Pudge, featuring stunning visual effects.", 2, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f", false, "Feast of Abscession", 22.9m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 2, new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A legendary knife skin for CS:GO with sleek animations and rare patterns.", 1, "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg", false, "Karambit", 199.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 3, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "An epic astronaut-themed skin for Fortnite, perfect for galactic explorers.", 3, "https://qudahalloween.com/cdn/shop/articles/Dark-Voyager-costume-featured_1201x.jpg?v=1719395076", false, "Dark Voyager", 14.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 4, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A dynamic skin for Lux that changes elements during the match.", 6, "https://i.pinimg.com/originals/f8/31/92/f83192912b8b605cc046810c47e9b8e7.jpg", false, "Elementalist Lux", 24.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 5, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "A rare arcana skin for Pudge, featuring stunning visual effects.", 2, "https://dota-showcase.com/storage/econ/items/phantom_assassin/manifold_paradox/arcana_pa_style2.png", false, "Manifold Paradox", 19.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 6, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The fabled blades that shattered the Anvil Magus Hroth. Its terrible weight dented and shattered his iron shell, just as its blades tore into the enchanted hide beneath.", 2, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXB9AJbIo8h5hlcX0TVVduv287XVk5LJxFZsragejhs0uHPdHMXuIzgwtaIk6_wMuvUwDoF7pJ12-_D8Ijw0FG1-UVpMTr2LYGQdVA2fxiOrTHuJria/360fx360f", false, "Inscribed The Basher Blades", 6.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 7, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "High risk and high reward, the infamous AWP is recognizable by its signature report and one-shot, one-kill policy. It has been painted by airbrushing transparent paints that fade together over a chrome base coat. This isn't just a weapon, it's a conversation piece - Imogen, Arms Dealer In Training", 1, "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAZh7PLfYQJE7dizq4yCkP_gfezXxj0IvJBy2rrH9NSh2VXs80VsYWGnd9SWcAFoaFCEqVa7wu3oh5Gi_MOeScxOzqI/360fx360f", false, "AWP | Fade", 1799.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 7 },
                    { 8, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A unique skin for Wraith that delves into her mysterious past.", 13, "https://cdnb.artstation.com/p/assets/images/images/027/923/487/4k/gary-huang-voidwalker-master.jpg?1592962782", false, "Wraith Voidwalker", 11.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 1 },
                    { 9, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "An ultra-rare mount with a ghostly tiger aesthetic.", 4, "https://wow.zamimg.com/uploads/screenshots/normal/1079770-reins-of-the-swift-spectral-tiger.jpg", false, "Swift Spectral Tiger", 499.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 6 },
                    { 10, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brutosaurs are used by the Zandalari Empire as both weapons of war and enormous, mobile trading posts.", 4, "https://wow.zamimg.com/uploads/screenshots/normal/742674-reins-of-the-mighty-caravan-brutosaur.jpg", false, "Reins of the Mighty Caravan Brutosaur", 290.99m, "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GameId",
                table: "Items",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PublisherId",
                table: "Items",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SubtypeId",
                table: "Items",
                column: "SubtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubtypes_ItemTypeId",
                table: "ItemSubtypes",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersItems_UserId",
                table: "UsersItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UsersItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "ItemSubtypes");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "ItemTypes");
        }
    }
}
