using GamerMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerMarketApp.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                 .HasData(this.SeedGames());

        }

        private IEnumerable<Game> SeedGames()
        {
            var games = new List<Game>()
            {
                new Game
                {
                    GameId = 1,
                    Title = "Counter-Strike: Global Offensive",
                    Description = "A competitive first-person shooter where players join terrorists or counter-terrorists in objective-based matches. It features a massive trading market for weapon skins.",
                    ImageUrl = "https://cdn.akamai.steamstatic.com/steam/apps/730/header.jpg",
                    GenreId = 4
                },
                new Game
                {
                    GameId = 2,
                    Title = "Dota 2",
                    Description = "A team-based MOBA game where two teams of five players control heroes with unique abilities to destroy the enemy's base, featuring a robust economy for hero cosmetics.",
                    ImageUrl = "https://cdn.akamai.steamstatic.com/steam/apps/570/header.jpg",
                    GenreId = 9
                },
                new Game
                {
                    GameId = 3,
                    Title = "Fortnite",
                    Description = "A vibrant battle royale game with a unique building mechanic. Players compete to survive, featuring purchasable character skins, emotes, and accessories.",
                    ImageUrl = "https://cdn2.unrealengine.com/fortnite/home/fortnite-logo.jpg",
                    GenreId = 14
                },
                new Game
                {
                    GameId = 4,
                    Title = "World of Warcraft",
                    Description = "A genre-defining MMORPG where players explore Azeroth, completing quests and engaging in battles. Offers tradable mounts, pets, and unique cosmetic items.",
                    ImageUrl = "https://bnetcmsus-a.akamaihd.net/cms/blog_header/6m/6MMZ3YS6CUEY1538596859767.jpg",
                    GenreId = 8
                },
                new Game
                {
                    GameId = 5,
                    Title = "Team Fortress 2",
                    Description = "A classic team-based shooter featuring various character classes. Players trade cosmetic hats, weapons, and items to customize their experience.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/440/header.jpg",
                    GenreId = 10
                },
                new Game
                {
                    GameId = 6,
                    Title = "League of Legends",
                    Description = "A fast-paced strategy game where two teams of champions compete to destroy each other's nexus. Players can purchase skins and accessories to personalize their gameplay.",
                    ImageUrl = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg",
                    GenreId = 9
                },
                new Game
                {
                    GameId = 7,
                    Title = "Rust",
                    Description = "A brutal survival game where players gather resources, build bases, and fend off others. Skins for tools and clothing can be bought and traded.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/252490/header.jpg",
                    GenreId = 7
                },
                new Game
                {
                    GameId = 8,
                    Title = "PUBG: Battlegrounds",
                    Description = "A realistic battle royale game where players fight to survive in large, detailed maps. It features purchasable and tradable weapon skins and outfits.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/578080/header.jpg",
                    GenreId = 14
                },
                new Game
                {
                    GameId = 9,
                    Title = "Roblox",
                    Description = "A creative gaming platform where users can design and play games. Features an expansive marketplace for user-created items and skins.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/66/Roblox_Logo.png",
                    GenreId = 15
                },
                new Game
                {
                    GameId = 10,
                    Title = "Call of Duty: Warzone",
                    Description = "A high-intensity battle royale with tactical gunfights and squad dynamics. Includes purchasable weapon blueprints, operator skins, and bundles.",
                    ImageUrl = "https://cdn.callofduty.com/cdn/cod/warzone/home-hero.jpg",
                    GenreId = 14
                },
                new Game
                {
                    GameId = 11,
                    Title = "EVE Online",
                    Description = "A space-based MMORPG where players engage in trading, exploration, and massive battles. Features a player-driven economy with tradable ships and skins.",
                    ImageUrl = "https://cdn1.eveonline.com/community/online/logo.jpg",
                    GenreId = 8
                },
                new Game
                {
                    GameId = 12,
                    Title = "The Elder Scrolls Online",
                    Description = "An MMORPG set in the rich Elder Scrolls universe, featuring expansive quests and dungeons. Players can buy mounts, costumes, and furnishings.",
                    ImageUrl = "https://images.elderscrollsonline.com/images/fb/fbde43a6da77d05a73830e8722fa245b.jpg",
                    GenreId = 8
                },
                new Game
                {
                    GameId = 13,
                    Title = "Apex Legends",
                    Description = "A fast-paced battle royale with unique hero abilities. Features a variety of skins and cosmetics available for purchase.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1172470/header.jpg",
                    GenreId = 14
                },
                new Game
                {
                    GameId = 14,
                    Title = "Minecraft",
                    Description = "A sandbox game where players can build, mine, and explore an infinite world. Offers a marketplace for skins, texture packs, and other in-game content.",
                    ImageUrl = "https://www.minecraft.net/content/dam/minecraft/logos/og-minecraft-logo.jpg",
                    GenreId = 15
                }
            };

            return games;
        }
    }

}
