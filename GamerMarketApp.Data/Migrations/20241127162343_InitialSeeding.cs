using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "ItemsTypes",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemSubtypes",
                keyColumn: "SubtypeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemsTypes",
                keyColumn: "ItemTypeId",
                keyValue: 10);
        }
    }
}
