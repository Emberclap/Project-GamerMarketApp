using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace GamerMarketApp.Services.Data
{
    public class ItemService(IItemRepository itemRepository) : IItemService
    {
        private readonly IItemRepository itemRepository = itemRepository;

        public async Task AddItemAsync(ItemAddViewModel model, string userId)
        {
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }

            var Item = new Item()
            {
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Name = model.Name,
                SubtypeId = model.SubtypeId,
                AddedOn = addedOn,
                GameId = model.GameId,
                PublisherId = userId,
                Price = model.Price
            };
            await itemRepository.AddAsync(Item);
        }

        public Task AddToFavoriteAsync(string userId, int gameId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteItemAsync(int id)
        {
            var entity = await itemRepository
                .FirstOrDefaultAsync(i => i.ItemId == id);
            await itemRepository.DeleteAsync(entity);
        }

        public async Task EditItemAsync(ItemAddViewModel model)
        {
            if (model == null)
            {
                return;
            }
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }
            var entity = new Item()
            {
                ItemId = model.ItemId,
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = addedOn,
                GameId = model.GameId,
                Price = model.Price,
                PublisherId = model.PublisherId,
                SubtypeId = model.SubtypeId,
            };
            await itemRepository.UpdateAsync(entity);

        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetAllItemsAsync()
        {
            return await itemRepository.GetAllAttached()
               .Where(i => i.IsDeleted == false)
               .Select(i => new ItemPreviewViewModel()
               {
                   ItemId = i.ItemId,
                   Name = i.Name,
                   Description = i.Description,
                   Game = i.Game.Title,
                   ImageUrl = i.ImageUrl,
                   Subtype = i.Subtype.Name,
                   Price = i.Price.ToString("# ###.00"),
               })
               .ToListAsync();
        }

        public async Task<ItemAddViewModel> GetItemAddModelAsync()
        {
            var model = new ItemAddViewModel()
            {
                Games = (List<Game>)await itemRepository.GetGamesAsync(),
                ItemSubtypes = (List<ItemSubtype>)await itemRepository.GetItemSubtypesAsync()
            };
            return model;
        }

        public async Task<ItemDeleteViewModel> GetItemDeleteModelAsync(int id)
        {
            var entity = await itemRepository.GetAllAttached()
                .Include(g => g.Game)
                .Where(i => !i.IsDeleted)
                .Select(i => new ItemDeleteViewModel()
            {
                ItemId = i.ItemId,
                Name = i.Name,
                ImageUrl = i.ImageUrl,
                Description = i.Description,
                Game = i.Game.Title,
                Price = i.Price.ToString("# ###.00"),
                AddedOn = i.AddedOn.ToString("dd/MM/yyyy"),
                SubType = i.Subtype.Name,
                Publisher = i.Publisher.UserName,
            })
            .FirstOrDefaultAsync(g => g.ItemId == id);
            return entity;
        }

        public async Task<ItemDetailsViewModel> GetItemDetailsAsync(int id)
        {
            return await itemRepository.GetItemDetailsAsync(id);
        }

        public async Task<ItemAddViewModel> GetItemEditModelAsync(int id)
        {
            var item = await itemRepository.FirstOrDefaultAsync(g => g.ItemId == id);

            var model = new ItemAddViewModel()
            {
                ItemId = item.ItemId,
                Name = item.Name,
                AddedOn = item.AddedOn.ToString("dd/MM/yyyy"),
                Description = item.Description,
                ImageUrl = item.ImageUrl,
                Price = item.Price,
                GameId = item.GameId,
                SubtypeId = item.SubtypeId,
                PublisherId = item.PublisherId,
            };
            model.Games = (List<Game>)await itemRepository.GetGamesAsync();
            model.ItemSubtypes = (List<ItemSubtype>)await itemRepository.GetItemSubtypesAsync();
            return model;
        }

        public Task<IEnumerable<ItemPreviewViewModel>> GetMyFavoriteItemsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromFavoriteAsync(string userId, int gameId)
        {
            throw new NotImplementedException();
        }

        public async Task SoftDeleteItemAsync(int id)
        {
            var entity = await itemRepository.GetByIdAsync(id);

            entity.IsDeleted = true;

            await this.itemRepository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetAllDeletedItemsAsync()
        {
            return await itemRepository.GetAllAttached()
                .Where(i => i.IsDeleted == true)
                .Select(i => new ItemPreviewViewModel()
                {
                    ItemId = i.ItemId,
                    Name = i.Name,
                    ImageUrl = i.ImageUrl,
                    Game = i.Game.Title,
                    Description = i.Description,
                    Price = i.Price.ToString("# ###.00"),
                    Subtype = i.Subtype.Name
                })
                .ToListAsync();
        }
    }
}
