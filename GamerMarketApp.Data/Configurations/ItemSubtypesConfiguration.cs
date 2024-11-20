using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerMarketApp.Data.Configurations
{
    public class ItemSubTypesConfiguration : IEntityTypeConfiguration<ItemSubtype>
    {
        public void Configure(EntityTypeBuilder<ItemSubtype> builder)
        {
            builder
                 .HasData(this.SeedItemSubtypes());

        }


        private IEnumerable<ItemSubtype> SeedItemSubtypes()
        {
            var subtypes = new List<ItemSubtype>()
            {
                // Subtypes for "Cosmetic Items"
                new ItemSubtype { SubtypeId = 1, Name = "Skins", Description = "Custom appearances for characters, weapons, or vehicles.", ItemTypeId = 1 },
                new ItemSubtype { SubtypeId = 2, Name = "Hats/Helmets", Description = "Decorative headgear for characters.", ItemTypeId = 1 },
                new ItemSubtype { SubtypeId = 3, Name = "Emotes/Dances", Description = "Custom animations for characters, such as dances or gestures.", ItemTypeId = 1 },
                new ItemSubtype { SubtypeId = 4, Name = "Sprays", Description = "Customizable graffiti or tags used in-game.", ItemTypeId = 1 },
                new ItemSubtype { SubtypeId = 5, Name = "Pets", Description = "Companion creatures that follow the player.", ItemTypeId = 1 },
                new ItemSubtype { SubtypeId = 6, Name = "Mounts", Description = "Vehicles or creatures used for faster travel or aesthetics.", ItemTypeId = 1 },

                // Subtypes for "Functional Equipment"
                new ItemSubtype { SubtypeId = 7, Name = "Weapons", Description = "Guns, swords, or other items used in combat.", ItemTypeId = 2 },
                new ItemSubtype { SubtypeId = 8, Name = "Armor", Description = "Gear providing protection or stat boosts.", ItemTypeId = 2 },
                new ItemSubtype { SubtypeId = 9, Name = "Vehicles", Description = "Transport or combat vehicles, often tradable.", ItemTypeId = 2 },

                // Subtypes for "Consumables"
                new ItemSubtype { SubtypeId = 10, Name = "Health Potions", Description = "Items that restore health points (HP).", ItemTypeId = 3 },
                new ItemSubtype { SubtypeId = 11, Name = "Buffs", Description = "Temporary stat-boosting consumables.", ItemTypeId = 3 },
                new ItemSubtype { SubtypeId = 12, Name = "Revival Items", Description = "Items that resurrect players or allies.", ItemTypeId = 3 },

                // Subtypes for "Crafting Materials"
                new ItemSubtype { SubtypeId = 13, Name = "Ores/Metals", Description = "Materials used for crafting weapons or armor.", ItemTypeId = 4 },
                new ItemSubtype { SubtypeId = 14, Name = "Herbs", Description = "Ingredients used for alchemy or potion-making.", ItemTypeId = 4 },
                new ItemSubtype { SubtypeId = 15, Name = "Blueprints/Recipes", Description = "Instructions for crafting specific items.", ItemTypeId = 4 },

                // Subtypes for "Currency"
                new ItemSubtype { SubtypeId = 16, Name = "Gold/Coins", Description = "In-game standard currency for trading.", ItemTypeId = 5 },
                new ItemSubtype { SubtypeId = 17, Name = "Premium Currency", Description = "Real-money currency for in-game purchases.", ItemTypeId = 5 },
                new ItemSubtype { SubtypeId = 18, Name = "Loot Boxes/Crates", Description = "Containers with random rewards.", ItemTypeId = 5 },

                // Subtypes for "Collectibles"
                new ItemSubtype { SubtypeId = 19, Name = "Trading Cards", Description = "Digital or physical cards collected by players.", ItemTypeId = 6 },

                // Subtypes for "Utility Items"
                new ItemSubtype { SubtypeId = 20, Name = "Bags/Inventory Space", Description = "Items that expand player inventory space.", ItemTypeId = 7 },

                // Subtypes for "Housing and Decor Items"
                new ItemSubtype { SubtypeId = 21, Name = "Furniture", Description = "Items for decorating player-owned spaces.", ItemTypeId = 8 },
                new ItemSubtype { SubtypeId = 22, Name = "Wall Art", Description = "Customizable decorations for in-game housing.", ItemTypeId = 8 },

                // Subtypes for "Event-Specific Items"
                new ItemSubtype { SubtypeId = 23, Name = "Holiday-Themed Skins", Description = "Limited-time skins available during events.", ItemTypeId = 9 },

                // Subtypes for "NFTs"
                new ItemSubtype { SubtypeId = 24, Name = "Blockchain-Based Assets", Description = "Unique, tradable assets tied to blockchain technology.", ItemTypeId = 10 }
            };

            return subtypes;
        }
    }
}


