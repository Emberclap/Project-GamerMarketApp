using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data.Repository
{
    public class ItemRepository(GamerMarketDbContext dbContext)
        : GenericRepository<Item>(dbContext), IItemRepository
    {
        public async Task<ItemDetailsViewModel?> GetItemDetailsAsync(int id)
        {
            return await context.Items
                 .Where(i => i.IsDeleted == false)
                 .Select(i => new ItemDetailsViewModel()
                 {
                     ItemId = i.ItemId,
                     Name = i.Name,
                     Description = i.Description,
                     Game = i.Game.Title,
                     Publisher = i.Publisher.UserName,
                     ImageUrl = i.ImageUrl,
                     SubType = i.Subtype.Name,
                     Price = i.Price.ToString("# ###.00"),
                     AddedOn = i.AddedOn.ToString("dd/MM/yyyy"),
                 })
                 .FirstOrDefaultAsync(g => g.ItemId == id);
        }

        public async Task<IEnumerable<Game>> GetGamesAsync()
        {
            return await context.Games.ToListAsync();
        }

        public async Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync()
        {
            return await context.ItemSubtypes.ToListAsync();
        }
    }
}
