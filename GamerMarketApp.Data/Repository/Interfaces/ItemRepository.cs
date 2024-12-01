using GamerMarketApp.Data.Models;
using GamerMarketApp.Web.ViewModels.Item;

namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<IEnumerable<Game>> GetGamesAsync();
        Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync();
    }
}
