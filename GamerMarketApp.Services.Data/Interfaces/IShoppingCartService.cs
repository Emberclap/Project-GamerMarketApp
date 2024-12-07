using GamerMarketApp.Data.Models;
using GamerMarketApp.Web.ViewModels.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IShoppingCartService
    {
        Task<ShoppingCartViewModel> GetCart(string userId);
        Task AddToCart(string userId, int itemId);
        Task RemoveFromCart(string userId, int itemId);
        Task ClearCart(string userId);
        Task<bool> AlreadyInCart(string userId, int itemId);
    }
}
