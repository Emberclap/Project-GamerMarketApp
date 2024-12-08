using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Game;
using GamerMarketApp.Services.Data;


namespace GamerMarketApp.Web.Controllers
{
    public class GameController(IGameService gameService)
            : BaseController
    {
 
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await gameService.GetAllGamesAsync();
            return View(model);
        }
        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeletedGames()
        {
            var model = await gameService.GetAllDeletedGamesAsync();
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles ="Moderator")]
        public async Task<IActionResult> AddGame()
        {
            var model = await gameService.GetAddModelAsync();
            return View(model);
        }
        
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGame(GameAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await gameService.AddGameAsync(model);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                ModelState.AddModelError("Game", "An error occurred while Adding the game.");
                return View(model); 
            }
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.GetEditModelAsync(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Edit(GameAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await gameService.EditGameAsync(model);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                ModelState.AddModelError("Game", "An error occurred while editing the game.");
                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Delete(int id)
        {      
            var model = await gameService.GetGameDeleteModelAsync(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await gameService.SoftDeleteGameAsync(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> BringGameBack(int id)
        {
            await gameService.UndoSoftDeleteGameAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await gameService.GetConfirmDeleteModelAsync(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteConfirmed(GameConfirmDeleteViewModel model)
        {
            try
            {
                await gameService.DeleteGameAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception )
            {
                ModelState.AddModelError("Game", "An error occurred while deleting the game.");
                return View(model); 
            }
        }
    }
}
