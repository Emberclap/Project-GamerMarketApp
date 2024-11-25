using GamerMarketApp.Web.ViewModels.Item;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IItemService
    {

        Task<ItemAddViewModel> GetItemAddModelAsync();

        Task AddItemAsync(ItemAddViewModel model , string userId);

        Task<IEnumerable<ItemPreviewViewModel>> GetAllItemsAsync();

        Task<ItemAddViewModel> GetItemEditModelAsync(int id);
        Task EditItemAsync(ItemAddViewModel model);
        Task SoftDeleteItemAsync(int id);
        Task<ItemDeleteViewModel> GetItemDeleteModelAsync(int id);
        Task DeleteItemAsync(ItemDeleteViewModel model);

        Task<IEnumerable<ItemPreviewViewModel>> GetMyFavoriteItemsAsync(string userId);
        Task AddToFavoriteAsync(string userId, int gameId);
        Task RemoveFromFavoriteAsync(string userId, int gameId);

        Task<ItemDetailsViewModel> GetItemDetailsAsync(int id);

    }
}
