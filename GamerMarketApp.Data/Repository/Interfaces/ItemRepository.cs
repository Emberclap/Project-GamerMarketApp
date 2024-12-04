using GamerMarketApp.Data.Models;

namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<IEnumerable<Game>> GetGamesAsync();
        Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync();
    }
}
