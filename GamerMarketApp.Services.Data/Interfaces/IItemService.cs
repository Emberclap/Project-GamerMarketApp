﻿using GamerMarketApp.Web.ViewModels.Item;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IItemService
    {
        Task<ItemAddViewModel> GetItemAddModelAsync();
        Task AddItemAsync(ItemAddViewModel model , string userId);
        Task<IEnumerable<ItemPreviewViewModel>> GetAllItemsAsync(string userId, AllItemsSearchFilterViewModel inputModel);
        Task<ItemEditViewModel> GetItemEditModelAsync(int id);
        Task EditItemAsync(ItemEditViewModel model);
        Task SoftDeleteItemAsync(int id);
        Task<ItemDeleteViewModel?> GetItemDeleteModelAsync(int id);
        Task DeleteItemAsync(int id);
        Task<ItemDetailsViewModel?> GetItemDetailsAsync(string userId, int id);
        Task<IEnumerable<ItemPreviewViewModel>> GetAllDeletedItemsAsync();
        Task<IEnumerable<ItemPreviewViewModel>> GetHomeItemsAsync();
        Task<IEnumerable<ItemPreviewViewModel>> GetMyItemsAsync(string userId, AllItemsSearchFilterViewModel inputModel);
    }
}
