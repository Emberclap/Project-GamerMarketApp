using Microsoft.AspNetCore.Mvc;
using GamerMarketApp.Web.ViewModels.Item;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;
using GamerMarketApp.Services.Data;

namespace GamerMarketApp.Web.Controllers
{
    public class ItemController(IItemService itemService) : BaseController
    {
        private readonly IItemService itemService = itemService;


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await itemService.GetAllItemsAsync();
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var item = await itemService.GetItemDetailsAsync(id);

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
            if (id == null)
            {
                return NotFound();
            }
            var model = await itemService.GetItemEditModelAsync(id);
            if (GetUserId() != model.PublisherId)
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
        public async Task<IActionResult> Edit(ItemAddViewModel model)
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
            return  RedirectToAction(nameof(Index));
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {

            var model = await this.itemService.GetItemDeleteModelAsync(id);
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
            await this.itemService.SoftDeleteItemAsync(Model.ItemId);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DeletedItems()
        {
            var model = await itemService.GetAllDeletedItemsAsync();
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HardDelete(int id)
        {
            await this.itemService.DeleteItemAsync(id);

            return RedirectToAction(nameof(DeletedItems));
        }

    }
}
