using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Game;


namespace GamerMarketApp.Web.Controllers
{

    public class GameController(IGameService gameService) : BaseController
    {
        private readonly IGameService gameService = gameService;

 
        [HttpGet]
        public async Task<IActionResult> AllGames()
        {
            var model = await gameService.GetAllGamesAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeletedGames()
        {
            var model = await gameService.GetAllDeletedGamesAsync();
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddGame()
        {
            var model = await gameService.GetAddModelAsync();
            return View(model);
        }
        
        [HttpPost]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await gameService.GetEditModelAsync(id);
            //if (GetUserId() != model.Publisher)
            //{
            //    return RedirectToAction(nameof(AllGames));
            //}
            return View(model);
            
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GameAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //ToDo: Moderator permission
            //if (GetUserId()
            //{
            //    return RedirectToAction(nameof(AllGames));
            //}
            await this.gameService.EditGameAsync(model);

            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [Authorize]
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SoftDelete(int id)
        {

            await this.gameService.SoftDeleteGameAsync(id);
            return RedirectToAction(nameof(AllGames));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BringGameBack(int id)
        {

            await this.gameService.UndoSoftDeleteGameAsync(id);
            return RedirectToAction(nameof(AllGames));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await gameService.GetConfirmDeleteModelAsync(id);
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(GameConfirmDeleteViewModel model)
        {

            await this.gameService.DeleteGameAsync(model);

            return RedirectToAction(nameof(AllGames));
        }
    }
}
