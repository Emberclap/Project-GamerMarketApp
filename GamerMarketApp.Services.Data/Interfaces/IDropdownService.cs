using GamerMarketApp.Data.Models;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IDropdownService
    {
        Task<IEnumerable<Genre>> GetGenresAsync();
        Task<IEnumerable<Game>> GetGamesAsync();
        Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync();
    }
}
