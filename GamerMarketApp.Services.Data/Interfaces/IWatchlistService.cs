using GamerMarketApp.Web.ViewModels.Item;
namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IWatchlistService
    {
        Task<IEnumerable<ItemPreviewViewModel>> GetMyWatchlistAsync(string userId);
        Task AddToWatchlistAsync(string userId, int gameId);
        Task RemoveFromWatchlistAsync(string userId, int gameId);
    }
}
