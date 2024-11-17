using GamerMarket.Data.Models;
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
                new ItemType { TypeId = 1, Name = "Cosmetic Items" },
                new ItemType { TypeId = 2, Name = "Functional Equipment" },
                new ItemType { TypeId = 3, Name = "Consumables" },
                new ItemType { TypeId = 4, Name = "Crafting Materials" },
                new ItemType { TypeId = 5, Name = "Currency" },
                new ItemType { TypeId = 6, Name = "Collectibles" },
                new ItemType { TypeId = 7, Name = "Utility Items" },
                new ItemType { TypeId = 8, Name = "Housing and Decor Items" },
                new ItemType { TypeId = 9, Name = "Event-Specific Items" },
                new ItemType { TypeId = 10, Name = "NFTs (Non-Fungible Tokens)" }
            };

            return itemTypes;
        }
    }

}
