﻿using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerMarketApp.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                 .HasData(this.SeedItems());  
        }


        private IEnumerable<Item> SeedItems()
        {
            var items = new List<Item>()
            {
                new Item()
                {
                    ItemId = 1,
                    Name = "Feast of Abscession",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 25.9m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1

                },
                new Item
                {
                    ItemId = 2,
                    Name = "Karambit",
                    Description = "A legendary knife skin for CS:GO with sleek animations and rare patterns.",
                    ImageUrl = "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg",
                    GameId = 1,
                    AddedOn = RandomDate(),
                    Price = 333.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 3,
                    Name = "Dark Voyager",
                    Description = "An epic astronaut-themed skin for Fortnite, perfect for galactic explorers.",
                    ImageUrl = "https://qudahalloween.com/cdn/shop/articles/Dark-Voyager-costume-featured_1201x.jpg?v=1719395076",
                    GameId = 3,
                    AddedOn = RandomDate(),
                    Price = 66.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 4,
                    Name = "Elementalist Lux",
                    Description = "A dynamic skin for Lux that changes elements during the match.",
                    ImageUrl = "https://i.pinimg.com/originals/f8/31/92/f83192912b8b605cc046810c47e9b8e7.jpg",
                    GameId = 6,
                    AddedOn = RandomDate(),
                    Price = 33.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 5,
                    Name = "Manifold Paradox",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://dota-showcase.com/storage/econ/items/phantom_assassin/manifold_paradox/arcana_pa_style2.png",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 25.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 6,
                    Name = "Inscribed The Basher Blades",
                    Description = "The fabled blades that shattered the Anvil Magus Hroth. Its terrible weight dented and shattered his iron shell, just as its blades tore into the enchanted hide beneath.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXB9AJbIo8h5hlcX0TVVduv287XVk5LJxFZsragejhs0uHPdHMXuIzgwtaIk6_wMuvUwDoF7pJ12-_D8Ijw0FG1-UVpMTr2LYGQdVA2fxiOrTHuJria/360fx360f",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 15.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 7,
                    Name = "AWP | Fade",
                    Description = "High risk and high reward, the infamous AWP is recognizable by its signature report and one-shot, one-kill policy. It has been painted by airbrushing transparent paints that fade together over a chrome base coat. This isn't just a weapon, it's a conversation piece - Imogen, Arms Dealer In Training",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAZh7PLfYQJE7dizq4yCkP_gfezXxj0IvJBy2rrH9NSh2VXs80VsYWGnd9SWcAFoaFCEqVa7wu3oh5Gi_MOeScxOzqI/360fx360f",
                    GameId = 1,
                    AddedOn = RandomDate(),
                    Price = 2599.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 7
                },
                new Item
                {
                    ItemId = 8,
                    Name = "Wraith Voidwalker",
                    Description = "A unique skin for Wraith that delves into her mysterious past.",
                    ImageUrl = "https://cdnb.artstation.com/p/assets/images/images/027/923/487/4k/gary-huang-voidwalker-master.jpg?1592962782",
                    GameId = 13,
                    AddedOn = RandomDate(),
                    Price = 15.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 9,
                    Name = "Swift Spectral Tiger",
                    Description = "An ultra-rare mount with a ghostly tiger aesthetic.",
                    ImageUrl = "https://wow.zamimg.com/uploads/screenshots/normal/1079770-reins-of-the-swift-spectral-tiger.jpg",
                    GameId = 4,
                    AddedOn = RandomDate(),
                    Price = 444.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 6
                },
                new Item
                {
                    ItemId = 10,
                    Name = "Reins of the Mighty Caravan Brutosaur",
                    Description = "Brutosaurs are used by the Zandalari Empire as both weapons of war and enormous, mobile trading posts.",
                    ImageUrl = "https://wow.zamimg.com/uploads/screenshots/normal/742674-reins-of-the-mighty-caravan-brutosaur.jpg",
                    GameId = 4,
                    AddedOn = RandomDate(),
                    Price = 250.99m,
                    PublisherId = "11b7f420-600c-4095-926f-677202d4235f",
                    SubtypeId = 6
                },
                new Item()
                {
                    ItemId = 11,
                    Name = "Feast of Abscession",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 22.9m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1

                },
                new Item
                {
                    ItemId = 12,
                    Name = "Karambit",
                    Description = "A legendary knife skin for CS:GO with sleek animations and rare patterns.",
                    ImageUrl = "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg",
                    GameId = 1,
                    AddedOn = RandomDate(),
                    Price = 199.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 13,
                    Name = "Dark Voyager",
                    Description = "An epic astronaut-themed skin for Fortnite, perfect for galactic explorers.",
                    ImageUrl = "https://qudahalloween.com/cdn/shop/articles/Dark-Voyager-costume-featured_1201x.jpg?v=1719395076",
                    GameId = 3,
                    AddedOn = RandomDate(),
                    Price = 14.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 14,
                    Name = "Elementalist Lux",
                    Description = "A dynamic skin for Lux that changes elements during the match.",
                    ImageUrl = "https://i.pinimg.com/originals/f8/31/92/f83192912b8b605cc046810c47e9b8e7.jpg",
                    GameId = 6,
                    AddedOn = RandomDate(),
                    Price = 24.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 15,
                    Name = "Manifold Paradox",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://dota-showcase.com/storage/econ/items/phantom_assassin/manifold_paradox/arcana_pa_style2.png",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 19.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 16,
                    Name = "Inscribed The Basher Blades",
                    Description = "The fabled blades that shattered the Anvil Magus Hroth. Its terrible weight dented and shattered his iron shell, just as its blades tore into the enchanted hide beneath.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXB9AJbIo8h5hlcX0TVVduv287XVk5LJxFZsragejhs0uHPdHMXuIzgwtaIk6_wMuvUwDoF7pJ12-_D8Ijw0FG1-UVpMTr2LYGQdVA2fxiOrTHuJria/360fx360f",
                    GameId = 2,
                    AddedOn = RandomDate(),
                    Price = 6.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 17,
                    Name = "AWP | Fade",
                    Description = "High risk and high reward, the infamous AWP is recognizable by its signature report and one-shot, one-kill policy. It has been painted by airbrushing transparent paints that fade together over a chrome base coat. This isn't just a weapon, it's a conversation piece - Imogen, Arms Dealer In Training",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FAZh7PLfYQJE7dizq4yCkP_gfezXxj0IvJBy2rrH9NSh2VXs80VsYWGnd9SWcAFoaFCEqVa7wu3oh5Gi_MOeScxOzqI/360fx360f",
                    GameId = 1,
                    AddedOn = RandomDate(),
                    Price = 1799.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 7
                },
                new Item
                {
                    ItemId = 18,
                    Name = "Wraith Voidwalker",
                    Description = "A unique skin for Wraith that delves into her mysterious past.",
                    ImageUrl = "https://cdnb.artstation.com/p/assets/images/images/027/923/487/4k/gary-huang-voidwalker-master.jpg?1592962782",
                    GameId = 13,
                    AddedOn = RandomDate(),
                    Price = 11.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 1
                },
                new Item
                {
                    ItemId = 19,
                    Name = "Swift Spectral Tiger",
                    Description = "An ultra-rare mount with a ghostly tiger aesthetic.",
                    ImageUrl = "https://wow.zamimg.com/uploads/screenshots/normal/1079770-reins-of-the-swift-spectral-tiger.jpg",
                    GameId = 4,
                    AddedOn = RandomDate(),
                    Price = 499.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 6
                },
                new Item
                {
                    ItemId = 20,
                    Name = "Reins of the Mighty Caravan Brutosaur",
                    Description = "Brutosaurs are used by the Zandalari Empire as both weapons of war and enormous, mobile trading posts.",
                    ImageUrl = "https://wow.zamimg.com/uploads/screenshots/normal/742674-reins-of-the-mighty-caravan-brutosaur.jpg",
                    GameId = 4,
                    AddedOn = RandomDate(),
                    Price = 290.99m,
                    PublisherId = "d5c07341-f610-4e1a-82af-792644004c7e",
                    SubtypeId = 6
                }
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
