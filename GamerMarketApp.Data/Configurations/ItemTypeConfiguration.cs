using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerMarketApp.Data.Configurations
{
    public class ItemTypeConfiguration : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder
                 .HasData(this.SeedItemTypes());

        }

        private IEnumerable<ItemType> SeedItemTypes()
        {
            var itemTypes = new List<ItemType>()
            {
                new ItemType { ItemTypeId = 1, Name = "Cosmetic Items" },
                new ItemType { ItemTypeId = 2, Name = "Functional Equipment" },
                new ItemType { ItemTypeId = 3, Name = "Consumables" },
                new ItemType { ItemTypeId = 4, Name = "Crafting Materials" },
                new ItemType { ItemTypeId = 5, Name = "Currency" },
                new ItemType { ItemTypeId = 6, Name = "Collectibles" },
                new ItemType { ItemTypeId = 7, Name = "Utility Items" },
                new ItemType { ItemTypeId = 8, Name = "Housing and Decor Items" },
                new ItemType { ItemTypeId = 9, Name = "Event-Specific Items" },
                new ItemType { ItemTypeId = 10, Name = "NFTs (Non-Fungible Tokens)" }
            };

            return itemTypes;
        }
    }

}
