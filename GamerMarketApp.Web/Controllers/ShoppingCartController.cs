using Elfie.Serialization;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace GamerMarketApp.Web.Controllers
{
    [Authorize]
    public class ShoppingCartController(IShoppingCartService cartService) : BaseController
    {
        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public async Task <IActionResult> Index()
        {
            var user = GetUserId();
            var model = await cartService.GetCart(user);
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AddToCart(int itemId, string source)
        {
            var userId = GetUserId();
            await cartService.AddToCart(userId, itemId);
            if (source == "Watchlist")
            {
                return RedirectToAction("Index", "Watchlist");
            }
            else if (source == "Items")
            {
                return RedirectToAction("Index", "Item");
            }
            else if (source == "Details")
            {
                return RedirectToAction("Details", "Item", new { itemId });
            }
            else
            {
                return RedirectToAction("Index", "ShoppingCart");
            }
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> RemoveFromCart(int itemId, string source)
        {
            var userId = GetUserId();
            await cartService.RemoveFromCart(userId, itemId);
            if (source == "Watchlist")
            {
                return RedirectToAction("Index", "Watchlist");
            }
            else if (source == "Items")
            {
                return RedirectToAction("Index", "Item");
            }
            else if(source == "Details")
            {
                return RedirectToAction("Details", "Item", new { itemId });
            }
            else
            {
                return RedirectToAction("Index", "ShoppingCart");
            }
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ClearCart()
        {
            var userId = GetUserId();
            await cartService.ClearCart(userId);
            return RedirectToAction("Index");
        }
    }
}
