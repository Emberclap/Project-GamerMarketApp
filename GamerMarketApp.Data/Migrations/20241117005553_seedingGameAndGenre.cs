using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GamerMarketApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedingGameAndGenre : Migration
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
                table: "Games",
                columns: new[] { "GameId", "Description", "GenreId", "ImageUrl", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, "A competitive first-person shooter where players join terrorists or counter-terrorists in objective-based matches. It features a massive trading market for weapon skins.", 4, "https://cdn.akamai.steamstatic.com/steam/apps/730/header.jpg", false, "Counter-Strike: Global Offensive" },
                    { 2, "A team-based MOBA game where two teams of five players control heroes with unique abilities to destroy the enemy's base, featuring a robust economy for hero cosmetics.", 9, "https://cdn.akamai.steamstatic.com/steam/apps/570/header.jpg", false, "Dota 2" },
                    { 3, "A vibrant battle royale game with a unique building mechanic. Players compete to survive, featuring purchasable character skins, emotes, and accessories.", 14, "https://cdn2.unrealengine.com/fortnite/home/fortnite-logo.jpg", false, "Fortnite" },
                    { 4, "A genre-defining MMORPG where players explore Azeroth, completing quests and engaging in battles. Offers tradable mounts, pets, and unique cosmetic items.", 8, "https://bnetcmsus-a.akamaihd.net/cms/blog_header/6m/6MMZ3YS6CUEY1538596859767.jpg", false, "World of Warcraft" },
                    { 5, "A classic team-based shooter featuring various character classes. Players trade cosmetic hats, weapons, and items to customize their experience.", 10, "https://cdn.cloudflare.steamstatic.com/steam/apps/440/header.jpg", false, "Team Fortress 2" },
                    { 6, "A fast-paced strategy game where two teams of champions compete to destroy each other's nexus. Players can purchase skins and accessories to personalize their gameplay.", 9, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg", false, "League of Legends" },
                    { 7, "A brutal survival game where players gather resources, build bases, and fend off others. Skins for tools and clothing can be bought and traded.", 7, "https://cdn.cloudflare.steamstatic.com/steam/apps/252490/header.jpg", false, "Rust" },
                    { 8, "A realistic battle royale game where players fight to survive in large, detailed maps. It features purchasable and tradable weapon skins and outfits.", 14, "https://cdn.cloudflare.steamstatic.com/steam/apps/578080/header.jpg", false, "PUBG: Battlegrounds" },
                    { 9, "A creative gaming platform where users can design and play games. Features an expansive marketplace for user-created items and skins.", 15, "https://upload.wikimedia.org/wikipedia/en/6/66/Roblox_Logo.png", false, "Roblox" },
                    { 10, "A high-intensity battle royale with tactical gunfights and squad dynamics. Includes purchasable weapon blueprints, operator skins, and bundles.", 14, "https://cdn.callofduty.com/cdn/cod/warzone/home-hero.jpg", false, "Call of Duty: Warzone" },
                    { 11, "A space-based MMORPG where players engage in trading, exploration, and massive battles. Features a player-driven economy with tradable ships and skins.", 8, "https://cdn1.eveonline.com/community/online/logo.jpg", false, "EVE Online" },
                    { 12, "An MMORPG set in the rich Elder Scrolls universe, featuring expansive quests and dungeons. Players can buy mounts, costumes, and furnishings.", 8, "https://images.elderscrollsonline.com/images/fb/fbde43a6da77d05a73830e8722fa245b.jpg", false, "The Elder Scrolls Online" },
                    { 13, "A fast-paced battle royale with unique hero abilities. Features a variety of skins and cosmetics available for purchase.", 14, "https://cdn.cloudflare.steamstatic.com/steam/apps/1172470/header.jpg", false, "Apex Legends" },
                    { 14, "A sandbox game where players can build, mine, and explore an infinite world. Offers a marketplace for skins, texture packs, and other in-game content.", 15, "https://www.minecraft.net/content/dam/minecraft/logos/og-minecraft-logo.jpg", false, "Minecraft" }
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
        }
    }
}
