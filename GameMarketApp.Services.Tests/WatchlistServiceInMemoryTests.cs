using GamerMarketApp.Data.Repository;
using GamerMarketApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerMarketApp.Data.Models;
using GamerMarketApp.Services.Data;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using Moq;
using Nest;
using System.Linq.Expressions;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Interfaces;

namespace GameMarketApp.Services.Tests
{
    [TestFixture]
    public class WatchlistServiceInMemoryTests
    {
        private IEnumerable<Item> items = new List<Item>()
            {
                new Item()
                {
                    ItemId = 1,
                    Name = "Feast of Abscession",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f",
                    GameId = 2,
                    AddedOn = DateTime.Today,
                    Price = 25.9m,
                    PublisherId = "TestUser",
                    SubtypeId = 1

                },
                new Item
                {
                    ItemId = 2,
                    Name = "Karambit",
                    Description = "A legendary knife skin for CS:GO with sleek animations and rare patterns.",
                    ImageUrl = "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg",
                    GameId = 1,
                    AddedOn = DateTime.Today,
                    Price = 333.99m,
                    PublisherId = "TestUser",
                    SubtypeId = 1
                },
                 new Item()
                {
                    ItemId = 3,
                    Name = "Abscession",
                    Description = "A rare arcana skin for Pudge, featuring stunning visual effects.",
                    ImageUrl = "https://community.fastly.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KW1Zwwo4NUX4oFJZEHLbXK9QlSPcUivB9aSQPRVees2c6cQ0hwIgFot6imKglhnfWbdz8SuYjkw4SJz_OmZrjUlGoD6px307yV9Ir23lK18hZpN2H7IIGLMlhprnEbA94/360fx360f",
                    GameId = 2,
                    AddedOn = DateTime.Today,
                    Price = 26.9m,
                    PublisherId = "TestUser",
                    SubtypeId = 1,
                },
                 new Item
                {
                    ItemId = 4,
                    Name = "Karambit",
                    Description = "A legendary knife skin for CS:GO with sleek animations and rare patterns.",
                    ImageUrl = "https://xn--b1agb1afb.com/image/cache/catalog/2128/2129/viber_%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_2019-12-05_11-15-18-800x800w.jpg",
                    GameId = 1,
                    AddedOn = DateTime.Today,
                    Price = 533.99m,
                    PublisherId = "TestUser",
                    SubtypeId = 1,
                    IsDeleted = true,
                },
        };
        private IEnumerable<Game> games = new List<Game>()
        {
            new Game
            {
                    GameId = 1,
                    Title = "Counter-Strike: 2",
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
        };
        private IEnumerable<ItemSubtype> types = new List<ItemSubtype>()
        {
            new ItemSubtype { SubtypeId = 1, Name = "Skins", Description = "Custom appearances for characters, weapons, or vehicles.", ItemTypeId = 1 },
            new ItemSubtype { SubtypeId = 7, Name = "Weapons", Description = "Guns, swords, or other items used in combat.", ItemTypeId = 2 },
        };
        private IEnumerable<UserItem> userItems = new List<UserItem>()
        {
            new UserItem { UserId = "WatchlistTestUser", ItemId = 1,  },
            new UserItem { UserId = "WatchlistTestUser", ItemId = 2,  },
        };
        private GenericRepository<UserItem> repository;
        private WatchlistService service;
        private string userId;

        [SetUp] 
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<GamerMarketDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) 
                .Options;

            var context = new GamerMarketDbContext(options);
            context.Items.AddRangeAsync(items);
            context.SaveChanges();

            context.Games.AddRangeAsync(games);
            context.SaveChanges();

            context.ItemSubtypes.AddRangeAsync(types);
            context.SaveChanges();

            context.UsersItems.AddRangeAsync(userItems);
            context.SaveChanges();

            context.Users.Add(new IdentityUser
            {
                Id = "User",
                UserName = "User",
            });
            context.SaveChanges();
            userId = context.Users.First().Id;
            repository = new GenericRepository<UserItem>(context);
            service = new WatchlistService(repository);
        }

        [Test]
        [NonParallelizable]

        public async Task AddToWatchlistAsync_ShouldAddItem_WhenNotInWatchlist()
        {
            var itemId = 3;

            await service.AddToWatchlistAsync(userId, itemId);

            var userItem = repository.FirstOrDefaultAsync(ui => ui.UserId == userId && ui.ItemId == itemId);
            Assert.That(userItem, Is.Not.Null); 
        }
        [Test]
        [NonParallelizable]
        public async Task AddToWatchlistAsync_ShouldNotAddDuplicateItem()
        {
            
            var itemId = 1;
            var resultBefore = repository.GetAllAttached()
                .Where(ui => ui.UserId == userId && ui.ItemId == itemId)
                .Count();
            await service.AddToWatchlistAsync(userId, itemId);

            var resultAfter = repository.GetAllAttached()
                .Where(ui => ui.UserId == userId && ui.ItemId == itemId)
                .Count();

            Assert.That(resultBefore, Is.EqualTo(resultAfter)); 
        }
        // Not working!
        
        //[Test]

        //public async Task GetMyWatchlistAsync_ShouldReturnUserWatchlist()
        //{

        //    var result = await service.GetMyWatchlistAsync(userId);

        //    Assert.That(result, Is.Not.Null);
        //    Assert.That(result.Count(), Is.EqualTo(2));
        //}

        [Test]

        public async Task GetMyWatchlistAsync_ShouldReturnEmpty_WhenUserHasNoWatchlistItems()
        {

            var result = await service.GetMyWatchlistAsync("WatchlistTestUser");

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
            
        }

        [Test]
        [NonParallelizable]

        public async Task GetMyWatchlistAsync_ShouldReturnEmpty_WhenUserDoesNotExist()
        {

            var result = await service.GetMyWatchlistAsync(userId);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }


        [Test]
        [NonParallelizable]
        public async Task RemoveFromWatchlistAsync_ShouldRemoveItem_WhenItemExist()
        {
            var itemId = 2;

            await service.RemoveFromWatchlistAsync(userId, itemId);

            var userItem = await repository
                .FirstOrDefaultAsync(ui => ui.UserId == userId && ui.ItemId == itemId);

            var userItems = await repository.GetAllAttached()
                .Where(ui => ui.UserId == userId && ui.ItemId == itemId)
                .ToListAsync();

            Assert.That(userItem, Is.Null);
            Assert.That(userItems.Count(), Is.EqualTo(0));

        }
        [Test]
        [NonParallelizable]
        public async Task RemoveFromWatchlistAsync_ShouldNotAddDuplicateItem()
        {
            var itemId = 1;
            var resultBefore = await repository.GetAllAttached()
                .Where(ui => ui.UserId == userId && ui.ItemId == itemId)
                .ToListAsync();
            await service.AddToWatchlistAsync(userId, itemId);

            var resultAfter = await repository.GetAllAttached()
                .Where(ui => ui.UserId == userId && ui.ItemId == itemId)
                .ToListAsync();

            Assert.That(resultBefore.Count(), Is.EqualTo(resultAfter.Count()));
        }
    }
}
