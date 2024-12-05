using Microsoft.AspNetCore.Mvc;
using GamerMarketApp.Web.ViewModels.Item;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

namespace GamerMarketApp.Web.Controllers
{
    public class ItemController(IItemService itemService) 
        : BaseController
    {

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var userId = GetUserId();
            var model = await itemService.GetAllItemsAsync(userId);
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();

            var item = await itemService.GetItemDetailsAsync(userId, id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Add()
        {
            var model = await itemService.GetItemAddModelAsync();
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ItemAddViewModel model)
        {

            if (!ModelState.IsValid)
            {
                model = await itemService.GetItemAddModelAsync();
                return View(model);
            }

            string userId = GetUserId();
            await itemService.AddItemAsync(model, userId);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var userId = GetUserId();
            var isModerator = User.IsInRole("Moderator");

            var model = await itemService.GetItemEditModelAsync(id);

            if (userId != model.PublisherId || !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }

            
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ItemEditViewModel model)
        {
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }

            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            await itemService.EditItemAsync(model);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var isModerator = User.IsInRole("Moderator");
            var model = await itemService.GetItemDeleteModelAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            if (GetUserId() != model.Publisher || !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ItemDeleteViewModel Model)
        {
            if (ModelState.IsValid)
            {
                return View(Model);
            }
            await itemService.SoftDeleteItemAsync(Model.ItemId);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeletedItems()
        {
            var model = await itemService.GetAllDeletedItemsAsync();
            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Moderator")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HardDelete(int id)
        {
            await itemService.DeleteItemAsync(id);

            return RedirectToAction(nameof(DeletedItems));
        }

    }
}
