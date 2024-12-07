using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Cart;
using GamerMarketApp.Web.ViewModels.Item;
using GamerMarketApp.Web.ViewModels.ShoppingCart;
using Microsoft.EntityFrameworkCore;
using Nest;
using static GamerMarketApp.Commons.EntityValidationConstants;

namespace GamerMarketApp.Services.Data
{
    public class ShoppingCartService(IGenericRepository<ShoppingCart> cartRepository,
        IGenericRepository<CartItem> cartItemRepository) : IShoppingCartService
    {
        public async Task AddToCart(string userId, int itemId)
        {
            var cart = await cartRepository.FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                cart = new ShoppingCart() { UserId = userId};
                await cartRepository.AddAsync(cart);
                            }
            var newCartItem = new CartItem()
            {
                ItemId = itemId,
                CartId = cart!.Id
            };
            var cartItemExist = await cartItemRepository
                .FirstOrDefaultAsync(i => i.ItemId == itemId && i.CartId == cart.Id);

            if (cartItemExist != null)
            {
                return;
            }
            await cartItemRepository.AddAsync(newCartItem);
        }

        public async Task ClearCart(string userId)
        {
            var cart = await cartRepository.FirstOrDefaultAsync(c => c.UserId == userId);
            if (cart == null)
            {
                return;
            }
            var cartItems = await cartItemRepository.GetAllAttached()
                .Where(c => c.CartId == cart.Id && c.Cart.UserId == userId)
                .ToListAsync();
            foreach( var cartItem in cartItems)
            {
                await cartItemRepository.DeleteAsync(cartItem);
            }
        }

        public async Task<ShoppingCartViewModel> GetCart(string userId)
        {
            var items = await cartItemRepository.GetAllAttached()
                .Where(i => i.Cart.UserId == userId)
                .Select(i => new ShoppingCartItemViewModel()
                {
                    ItemId = i.Item.ItemId,
                    Name = i.Item.Name,
                    Price = i.Item.Price,
                    Subtype = i.Item.Subtype.Name,
                })
                .ToListAsync();

            var cart = await cartRepository.FirstOrDefaultAsync(c => c.UserId == userId) ?? new ShoppingCart();
            var model = new ShoppingCartViewModel
            {
                CartItems = items,
                TotalPrice = items.Sum(p => p.Price),
                TotalQuantity = items.Count,
            };
            return model;
        }

        public async Task RemoveFromCart(string userId, int itemId)
        {
            var cart = await cartRepository.FirstOrDefaultAsync(c => c.UserId == userId);

            if (cart == null)
            {
                return;
            }
            var cartItem = await cartItemRepository
                .FirstOrDefaultAsync(ci => ci.ItemId == itemId);
            if (cartItem == null)
            {
                return;
            }
            await cartItemRepository.DeleteAsync(cartItem);
        }

        public async Task<bool> AlreadyInCart(string userName, int itemId)
        {
            var isInCart = await cartItemRepository
                .FirstOrDefaultAsync(i => i.ItemId == itemId && i.Cart.User.UserName == userName);
            if (isInCart == null)
            {
                return false;
            }
            return true;
        }
    }
}
