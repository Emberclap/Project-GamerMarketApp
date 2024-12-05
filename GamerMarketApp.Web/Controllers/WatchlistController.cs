using Elfie.Serialization;
using GamerMarketApp.Services.Data;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Web.Controllers
{
    [Authorize]
    public class WatchlistController(IWatchlistService watchlistService) : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();
            var model = await watchlistService.GetMyWatchlistAsync(userId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToMyWatchlist(int id, string source)
        {
            var userId = GetUserId();
            await watchlistService.AddToWatchlistAsync(userId, id);
            if (source == "Index")
            {
                return RedirectToAction("Index", "Item");
            }
            else
            {
                return RedirectToAction("Details", "Item", new { id });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromMyWatchlist(int id, string source)
        {
            var userId = GetUserId();
            await watchlistService.RemoveFromWatchlistAsync(userId, id);
            if(source == "Index")
            {
                return RedirectToAction("Index", "Item");
            }
            else if (source == "Details")
            {
                return RedirectToAction("Details", "Item", new { id });
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

