using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Data.Configurations
{
    public class ItemConfiguration
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            //builder
            //     .HasData(this.SeedItems());

        }

        private IEnumerable<Item> SeedItems()
        {
            var items = new List<Item>()
            {
               new Item
               {
                    //ItemId = 1,
                    //Name = "Dota 2 Arcana: Pudge",
                    //Description = "A rare arcana skin for Anti-Mage, featuring stunning visual effects.",
                    //ImageUrl = "/images/dota2_battlepass.jpg",
                    //GameId = 2,
                    //AddedOn = RandomDate(),
                    //Price = 9.99m,
                    //PublisherId = "",
                    //SubTypeId = "Battle Pass"
               },

            };

            return items;
        }

        private static DateTime RandomDate()
        {
            var random = new Random();
            var startDate = new DateTime(2023, 1, 1);
            var endDate = DateTime.Now;
            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
}
