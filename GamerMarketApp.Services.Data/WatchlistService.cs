using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Services.Data
{
    public class WatchlistService(IGenericRepository<UserItem> userItemRepository) : IWatchlistService
    {
        private readonly IGenericRepository<UserItem> userItemRepository = userItemRepository;

        public async Task AddToWatchlistAsync(string userId, int itemId)
        {
            var userItem = await userItemRepository
                .FirstOrDefaultAsync(ui => ui.ItemId == itemId && userId == ui.UserId);

            if (userItem != null)
            {
                return;
            }
            var newUserItem = new UserItem
            {
                UserId = userId,
                ItemId = itemId
            };
            await userItemRepository.AddAsync(newUserItem);
        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetMyWatchlistAsync(string userId)
        {
            return await userItemRepository.GetAllAttached()
                .Where(ui => ui.UserId == userId)
                .Select(ui => new ItemPreviewViewModel()
                {
                    ItemId = ui.Item.ItemId,
                    Name = ui.Item.Name,
                    Description = ui.Item.Description,
                    Game = ui.Item.Game.Title,
                    ImageUrl = ui.Item.ImageUrl,
                    Subtype = ui.Item.Subtype.Name,
                    Publisher = ui.Item.PublisherId,
                    Price = ui.Item.Price.ToString("# ###.00"),
                })
                .ToListAsync();

        }

        public async Task RemoveFromWatchlistAsync(string userId, int itemId)
        {
            var userItem = await userItemRepository
                .FirstOrDefaultAsync(ui => ui.ItemId == itemId && userId == ui.UserId);

            if (userItem == null)
            {
                return;
            }

            await userItemRepository.DeleteAsync(userItem);
        }
    }
}
