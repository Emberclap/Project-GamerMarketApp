using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Security.Claims;

namespace GamerMarketApp.Services.Data
{
    public class ItemService(IGenericRepository<Item> itemRepository) : IItemService
    {
        private readonly IGenericRepository<Item> itemRepository = itemRepository;
        
        public async Task AddItemAsync(ItemAddViewModel model, string userId)
        {
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }

            var Item = new Item()
            {
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Name = model.Name,
                SubTypeId = model.SubTypeId,
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

        public Task DeleteItemAsync(ItemDeleteViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task EditItemAsync(ItemAddViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetAllItemsAsync()
        {
            return await itemRepository.GetAllAttached()
                .Where(i => i.IsDeleted == false)
                .Select(i => new ItemPreviewViewModel()
                {
                    Name = i.Name,
                    Description = i.Description,
                    GameId = i.GameId,
                    ImageUrl = i.ImageUrl,
                    SubTypeId = i.SubTypeId,
                    Price = i.Price.ToString(),
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ItemAddViewModel> GetItemAddModelAsync()
        {
            var model = new ItemAddViewModel()
            {
                
            };
            return model;

        }

        public Task<ItemDeleteViewModel> GetItemDeleteModelAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ItemDetailsViewModel> GetItemDetailsAsync(int id)
        {
            return await itemRepository.GetAllAttached()
                .Where(i => i.IsDeleted == false)
                .Select(i => new ItemDetailsViewModel()
                {
                    Name = i.Name,
                    Description = i.Description,
                    GameId = i.GameId,
                    ImageUrl = i.ImageUrl,
                    SubTypeId = i.SubTypeId,
                    Price = i.Price.ToString(),
                })
                .FirstOrDefaultAsync();
        }

        public Task<ItemAddViewModel> GetItemEditModelAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ItemPreviewViewModel>> GetMyFavoriteItemsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromFavoriteAsync(string userId, int gameId)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
