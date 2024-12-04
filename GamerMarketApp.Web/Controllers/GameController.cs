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
        private readonly IGameService gameService = gameService;

 
        [HttpGet]
        public async Task<IActionResult> AllGames()
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
            await gameService.AddGameAsync(model);

            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.GetEditModelAsync(id);
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
            await this.gameService.EditGameAsync(model);

            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> Delete(int id)
        {      
            var model = await gameService.GetGameDeleteModelAsync(id);
            if (model == null)
            {
                return NotFound(model);
            }
                return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> SoftDelete(int id)
        {

            await this.gameService.SoftDeleteGameAsync(id);
            return RedirectToAction(nameof(AllGames));
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> BringGameBack(int id)
        {

            await this.gameService.UndoSoftDeleteGameAsync(id);
            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await gameService.GetConfirmDeleteModelAsync(id);
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteConfirmed(GameConfirmDeleteViewModel model)
        {

            await this.gameService.DeleteGameAsync(model);

            return RedirectToAction(nameof(AllGames));
        }
    }
}
