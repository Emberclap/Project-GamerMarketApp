using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data.Repository
{
    public class ItemRepository(GamerMarketDbContext dbContext)
        : GenericRepository<Item>(dbContext), IItemRepository
    {

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
