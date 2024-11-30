using GamerMarketApp.Services.Data;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Web.Controllers
{
    [Authorize]
    public class WatchlistController(IWatchlistService watchlistService) : BaseController
    {
        private readonly IWatchlistService watchlistService = watchlistService;

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();
            var model = await watchlistService.GetMyWatchlistAsync(userId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToMyWatchlist(int id)
        {
            var userId = GetUserId();
            await watchlistService.AddToWatchlistAsync(userId, id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromMyWatchlist(int id)
        {
            var userId = GetUserId();
            await watchlistService.RemoveFromWatchlistAsync(userId, id);
            return RedirectToAction(nameof(Index));
        }
    }
}

