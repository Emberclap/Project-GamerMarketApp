using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.IdentityModel.Tokens;
using MockQueryable;
using Moq;
using System.Globalization;
using System.Linq.Expressions;

namespace GameMarketApp.Services.Tests
{
    //Tests with Moq
    [TestFixture]
    public class ItemServiceTests()
    {
        private IEnumerable<Item> items;
        private IEnumerable<Game> games;
        private IEnumerable<ItemSubtype> types;
        private Mock<IItemRepository> mockItemRepository;
        private ItemService itemService;
        private readonly string userId = "TestUser";
        [SetUp]
        public void Setup()
        {
            items = new List<Item>()
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
        };
            games = new List<Game>()
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
            types = new List<ItemSubtype>()
        {
            new ItemSubtype { SubtypeId = 1, Name = "Skins", Description = "Custom appearances for characters, weapons, or vehicles.", ItemTypeId = 1 },
            new ItemSubtype { SubtypeId = 7, Name = "Weapons", Description = "Guns, swords, or other items used in combat.", ItemTypeId = 2 },
        };

            var itemsData = items.BuildMock();
            var gamesData = games.BuildMock();
            var typesData = types.BuildMock();

            mockItemRepository = new Mock<IItemRepository>();

            mockItemRepository
                .Setup(r => r.GetAllAttached())
                    .Returns(itemsData);
            mockItemRepository.Setup(r => r.GetGamesAsync())
                .ReturnsAsync(gamesData);
            mockItemRepository.Setup(r => r.GetItemSubtypesAsync())
                .ReturnsAsync(typesData);

            itemService = new ItemService(mockItemRepository.Object);
        }




        [Test]
        public async Task AddItemAsync_ValidInput_CallsRepositoryWithCorrectItem()
        {
            var model = new ItemAddViewModel
            {
                ImageUrl = "http://example.com/image.jpg",
                Description = "TestDescription",
                Name = "testItem",
                SubtypeId = 1,
                AddedOn = "01/01/2023",
                GameId = 1,
                Price = 100m
            };

            await itemService.AddItemAsync(model, userId);

            mockItemRepository.Verify(r => r.AddAsync(It.Is<Item>(item =>
                item.ImageUrl == model.ImageUrl &&
                item.Description == model.Description &&
                item.Name == model.Name &&
                item.SubtypeId == model.SubtypeId &&
                item.GameId == model.GameId &&
                item.Price == model.Price &&
                item.PublisherId == userId &&
                item.AddedOn == DateTime.ParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            )), Times.Once);
        }

        [Test]
        public void AddItemAsync_InvalidDate_ThrowsInvalidOperationException()
        {
            var model = new ItemAddViewModel
            {
                ImageUrl = "http://example.com/image.jpg",
                Description = "TestDescription",
                Name = "TestItem",
                SubtypeId = 1,
                AddedOn = "2023/01/01", // Invalid date
                GameId = 1,
                Price = 100m
            };
            var userId = "test-user-id";

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                itemService.AddItemAsync(model, userId));
        }

        [Test]
        public void AddItemAsync_NullModel_ThrowsArgumentNullException()
        {
            var model = new ItemAddViewModel
            {
                ImageUrl = "http://example.com/image.jpg",
                Description = "Test Description",
                Name = "TestItem",
                SubtypeId = 1,
                AddedOn = "2023/01/01", // Invalid date
                GameId = 1,
                Price = 100m,
            };
            Assert.ThrowsAsync<ArgumentNullException>(() =>
                itemService.AddItemAsync(null, userId));
        }


        [Test]
        public async Task DeleteItemAsync_ItemExists_CallsDeleteAsync()
        {
            var testItem = new Item { ItemId = 1, Name = "TestItem" };
            mockItemRepository
                .Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<Item, bool>>>()))
                .ReturnsAsync(testItem);

            await itemService.DeleteItemAsync(testItem.ItemId);

            mockItemRepository.Verify(r => r.DeleteAsync(testItem), Times.Once);
        }

        [Test]

        public async Task DeleteItemAsync_ItemDoesNotExist_DoesNotCallDeleteAsync()
        {
            mockItemRepository
                .Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<Item, bool>>>()))
                .ReturnsAsync((Item)null);

            await itemService.DeleteItemAsync(1);

            mockItemRepository.Verify(r => r.DeleteAsync(It.IsAny<Item>()), Times.Never);
        }

        [Test]

        public async Task DeleteItemAsync_InvalidId_DoesNotThrow()
        {
            await itemService.DeleteItemAsync(0);
            await itemService.DeleteItemAsync(-1);

            mockItemRepository.Verify(r => r.DeleteAsync(It.IsAny<Item>()), Times.Never);
        }

        [Test]
        public async Task EditItemAsync_ValidInput_CallsUpdateAsync()
        {
            var model = new ItemEditViewModel
            {
                ItemId = 1,
                Name = "TestItem",
                ImageUrl = "http://example.com/image.jpg",
                Description = "TestDescription",
                AddedOn = "01/01/2023",
                GameId = 1,
                Price = 19,
                PublisherId = userId,
                SubtypeId = 1
            };

            await itemService.EditItemAsync(model);

            mockItemRepository.Verify(r => r.UpdateAsync(It.Is<Item>(item =>
                item.ItemId == model.ItemId &&
                item.Name == model.Name &&
                item.ImageUrl == model.ImageUrl &&
                item.Description == model.Description &&
                item.AddedOn == DateTime.ParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture) &&
                item.GameId == model.GameId &&
                item.Price == model.Price &&
                item.PublisherId == userId &&
                item.SubtypeId == model.SubtypeId
            )), Times.Once);
        }

        [Test]
        public async Task EditItemAsync_NullModel_DoesNotThrow()
        {
            await itemService.EditItemAsync(null);

            mockItemRepository.Verify(r => r.UpdateAsync(It.IsAny<Item>()), Times.Never);
        }

        [Test]
        public void EditItemAsync_InvalidDate_ThrowsInvalidOperationException()
        {
            var model = new ItemEditViewModel
            {
                AddedOn = "2002/01/12",
                Name = "Test Item",
                ItemId = 1
            };

            Assert.ThrowsAsync<InvalidOperationException>(() =>
                itemService.EditItemAsync(model));
            mockItemRepository.Verify(r => r.UpdateAsync(It.IsAny<Item>()), Times.Never);
        }

        [Test]
        public async Task SoftDeleteItemAsync_ItemExists_SetsIsDeletedToTrue()
        {
            var testItem = new Item { ItemId = 1, IsDeleted = false };
            mockItemRepository
                .Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(testItem);

            await itemService.SoftDeleteItemAsync(testItem.ItemId);

            Assert.That(testItem.IsDeleted, Is.True); // Verify IsDeleted is set to true
            mockItemRepository.Verify(r => r.UpdateAsync(testItem), Times.Once);
        }

        [Test]
        public async Task SoftDeleteItemAsync_ItemDoesNotExist_DoesNotCallUpdateAsync()
        {
            mockItemRepository
                .Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((Item)null);

            await itemService.SoftDeleteItemAsync(1);

            mockItemRepository.Verify(r => r.UpdateAsync(It.IsAny<Item>()), Times.Never);
        }

        [Test]
        public async Task SoftDeleteItemAsync_CallsGetByIdAsyncWithCorrectId()
        {
            var testItemId = 1;
            mockItemRepository
                .Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new Item { ItemId = testItemId });

            await itemService.SoftDeleteItemAsync(testItemId);

            mockItemRepository.Verify(r => r.GetByIdAsync(testItemId), Times.Once);
        }
        [Test]
        public async Task GetItemAddModelAsync_ReturnsModelWithGamesAndSubtypes()
        {
            var gamesData = games.BuildMock();
            var typesData = types.BuildMock();

            mockItemRepository.Setup(r => r.GetGamesAsync())
                .ReturnsAsync(gamesData);
            mockItemRepository.Setup(r => r.GetItemSubtypesAsync())
                .ReturnsAsync(typesData);

            var result = await itemService.GetItemAddModelAsync();

            Assert.That(result, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(gamesData, Is.EqualTo(result.Games));
                Assert.That(typesData, Is.EqualTo(result.ItemSubtypes));
            });

            mockItemRepository.Verify(r => r.GetGamesAsync(), Times.Once);
            mockItemRepository.Verify(r => r.GetItemSubtypesAsync(), Times.Once);
        }

        [Test]
        public async Task GetMyItemsAsync_ReturnsEmptyWhenNoMatches()
        {
            var itemsData = items.BuildMock();
            mockItemRepository
                .Setup(r => r.GetAllAttached())
                .Returns(itemsData);
            var inputModel = new AllItemsSearchFilterViewModel
            {
                SearchQuery = "NonExistentItem",
                EntitiesPerPage = 8,
                CurrentPage = 1
            };

            var result = await itemService.GetMyItemsAsync(userId, inputModel);

            Assert.That(result.IsNullOrEmpty);
            Assert.That(inputModel.TotalPages, Is.EqualTo(0));
        }
    }
}



