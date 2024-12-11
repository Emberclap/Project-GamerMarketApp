using GamerMarketApp.Data.Repository;
using GamerMarketApp.Data;
using Microsoft.EntityFrameworkCore;
using GamerMarketApp.Data.Models;
using GamerMarketApp.Services.Data;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.IdentityModel.Tokens;
using GamerMarketApp.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query;

namespace GameMarketApp.Services.Tests
{
    [TestFixture]
    public class ItemServiceInMemoryTests
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
        private IItemRepository SetupInMemoryRepository()
        {
            var options = new DbContextOptionsBuilder<GamerMarketDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) 
                .Options;

            var context = new GamerMarketDbContext(options);
            context.Items.AddRangeAsync(items);
            context.Games.AddRangeAsync(games);
            context.ItemSubtypes.AddRangeAsync(types);
            context.Users.Add(new IdentityUser { Id = "TestUser", UserName = "TestUser" });
            context.SaveChanges();

            return new ItemRepository(context); 
        }
        [Test]
        public async Task GetItemEditModelAsync_ShouldReturnValidModel_WhenItemExists()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var result = await service.GetItemEditModelAsync(2);

            Assert.NotNull(result);
            Assert.That(result.ItemId, Is.EqualTo(2));
            Assert.That(result.Games, Is.Not.Null);
            Assert.That(result.ItemSubtypes, Is.Not.Null);
        }
        [Test]
        public async Task GetItemEditModelAsync_ShouldReturnNull_WhenItemDoesNotExist()
        {
            var repository = SetupInMemoryRepository();

            var service = new ItemService(repository);

            var result = await service.GetItemEditModelAsync(999); 

            Assert.Null(result);
        }
        [Test]
        public async Task GetMyItemsAsync_ShouldReturnFilteredItems_WhenFiltersApplied()
        {
            var repository = SetupInMemoryRepository();

            var service = new ItemService(repository);

            var result = await service
                 .GetMyItemsAsync("TestUser", new AllItemsSearchFilterViewModel()
                 {
                     SearchQuery = "kar",
                 });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1));
            var item = result.First();
            Assert.That(item.Name, Is.EqualTo("Karambit"));
            Assert.That(item.Game, Is.EqualTo("Counter-Strike: 2"));
        }
        [Test]
        public async Task GetMyItemsAsync_HandlesPaginationCorrectly()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var inputModel = new AllItemsSearchFilterViewModel
            {
                EntitiesPerPage = 1,
                CurrentPage = 2
            };
            var result = await service
                 .GetMyItemsAsync("TestUser", inputModel);


            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(inputModel.TotalPages, Is.EqualTo(3));
        }

        [Test]
        public async Task GetAllItemsAsync_ShouldReturnFilteredAndPaginatedResults()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var inputModel = new AllItemsSearchFilterViewModel
            {
                GameFilter = "dota 2",
                TypeFilter = "skins",
                EntitiesPerPage = 1,
            };

            IEnumerable<ItemPreviewViewModel> result = await service.GetAllItemsAsync("TestUser2", inputModel);

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(inputModel.TotalPages, Is.EqualTo(2));
            Assert.That(inputModel.CurrentPage, Is.EqualTo(1));
        }

        [Test]
        public async Task GetAllItemsAsync_ShouldReturnEmpty_WhenNoItemsMatchFilters()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var inputModel = new AllItemsSearchFilterViewModel
            {
                SearchQuery = "NonSuchItem",
            };

            var result = await service.GetAllItemsAsync("TestUser", inputModel);

            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(0)); 
        }
        [Test]
        public async Task GetAllItemsAsync_ShouldReturnPaginatedResults()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var inputModel = new AllItemsSearchFilterViewModel
            {
                EntitiesPerPage = 1 
            };

            var result = await service.GetAllItemsAsync("User1", inputModel);

            Assert.NotNull(result);
            Assert.That(inputModel.CurrentPage, Is.EqualTo(1));
            Assert.That(inputModel.TotalPages, Is.EqualTo(3));
        }

        [Test]
        public async Task GetItemDeleteModelAsync_ShouldReturnCorrectModel_WhenItemExists()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);
            var itemId = 2; 

            var result = await service.GetItemDeleteModelAsync(itemId);

            Assert.NotNull(result);
            Assert.That(result.ItemId, Is.EqualTo(itemId) );
            Assert.That(result.PublisherId, Is.EqualTo("TestUser")); 
        }

        [Test]
        public async Task GetItemDeleteModelAsync_ShouldReturnNull_WhenItemDoesNotExist()
        {
            var repository = SetupInMemoryRepository();

            var service = new ItemService(repository);
            var nonExistentItemId = 999;

            var result = await service.GetItemDeleteModelAsync(nonExistentItemId);

            Assert.Null(result);
        }

        [Test]
        public async Task GetItemDeleteModelAsync_ShouldReturnNull_WhenItemIsDeleted()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var deletedItemId = 4; 
            var result = await service.GetItemDeleteModelAsync(deletedItemId);

            Assert.Null(result);
        }
        [Test]
        public async Task GetItemDetailsAsync_ShouldReturnCorrectModel_WhenItemExists()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);
            var existingItemId = 2; 

            var result = await service.GetItemDetailsAsync("TestUser", existingItemId);

            Assert.NotNull(result);
            Assert.That(result.ItemId, Is.EqualTo(2));
            Assert.That(result.Name, Is.EqualTo("Karambit"));
            Assert.That(result.Publisher, Is.EqualTo("TestUser"));
        }

        [Test]
        public async Task GetItemDetailsAsync_ShouldReturnNull_WhenItemDoesNotExist()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);
            var nonExistentItemId = 999; 

            var result = await service.GetItemDetailsAsync("TestUser", nonExistentItemId);

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetItemDetailsAsync_ShouldReturnNull_WhenItemIsDeleted()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);
            var deletedItemId = 4; 

            var result = await service.GetItemDetailsAsync("TestUser", deletedItemId);

            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetAllDeletedItemsAsync_ShouldReturnAllDeletedItems()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var result = await service.GetAllDeletedItemsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1)); 
        }

        [Test]
        public async Task GetAllDeletedItemsAsync_ShouldReturnEmpty_WhenNoDeletedItemsExist()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);
            var item = await repository.GetByIdAsync(4);
            item.IsDeleted = false;
            await repository.SaveAsync();
            var result = await service.GetAllDeletedItemsAsync();
            item.IsDeleted = true;
            await repository.SaveAsync();


            Assert.That(result.IsNullOrEmpty);
        }

        [Test]
        public async Task GetHomeItemsAsync_ShouldReturnTopThreeItemsByPrice()
        {
            var repository = SetupInMemoryRepository();
            var service = new ItemService(repository);

            var result = await service.GetHomeItemsAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result.SequenceEqual(result.OrderByDescending(i => decimal.Parse(i.Price.Replace(" ", "")))), Is.True);
        }

        [Test]
        public async Task GetHomeItemsAsync_ShouldReturnEmpty_WhenNoItemsExist_OrItemsIsDeleted()
        {
            var repository = SetupInMemoryRepository();
            var items = repository.GetAllAttached();
            var item = await repository.GetByIdAsync(1);
            item.IsDeleted = true;
            var item1 = await repository.GetByIdAsync(2);
            item1.IsDeleted = true;
            var item2 = await repository.GetByIdAsync(3);
            item2.IsDeleted = true;
            await repository.SaveAsync();

            var service = new ItemService(repository);

            var result = await service.GetHomeItemsAsync();

            Assert.That(result.IsNullOrEmpty);
        }
    }
}

