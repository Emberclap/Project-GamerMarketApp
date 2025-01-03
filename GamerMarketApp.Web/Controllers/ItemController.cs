﻿using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index(AllItemsSearchFilterViewModel inputModel)
        {
            var userId = GetUserId();
            var itemModels = await itemService.GetAllItemsAsync(userId, inputModel);
            var searchModel = new AllItemsSearchFilterViewModel()
            {
                Items = itemModels,
                SearchQuery = inputModel.SearchQuery,
                GameFilter = inputModel.GameFilter,
                TypeFilter = inputModel.TypeFilter,
                AllGames = inputModel.AllGames,
                AllTypes = inputModel.AllTypes,
                CurrentPage = inputModel.CurrentPage,
                EntitiesPerPage = inputModel.EntitiesPerPage,
                TotalPages = inputModel.TotalPages,
            };

            return View(searchModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyItems(AllItemsSearchFilterViewModel inputModel)
        {
            var userId = GetUserId();
            var itemModels = await itemService.GetMyItemsAsync(userId, inputModel);
            var searchModel = new AllItemsSearchFilterViewModel()
            {
                Items = itemModels,
                SearchQuery = inputModel.SearchQuery,
                GameFilter = inputModel.GameFilter,
                TypeFilter = inputModel.TypeFilter,
                AllGames = inputModel.AllGames,
                AllTypes = inputModel.AllTypes,
                CurrentPage = inputModel.CurrentPage,
                EntitiesPerPage = inputModel.EntitiesPerPage,
                TotalPages = inputModel.TotalPages,
            };

            return View(nameof(MyItems),searchModel);
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
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Add(ItemAddViewModel model)
        {

            if (!ModelState.IsValid)
            {
                model = await itemService.GetItemAddModelAsync();
                return View(model);
            }
            string userId = GetUserId();
            try
            {

                await itemService.AddItemAsync(model, userId);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                ModelState.AddModelError("Item", "An error occurred while adding the item.");
                return View(model);
            }
            

            
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var userId = GetUserId();
            var isModerator = User.IsInRole("Moderator");

            var model = await itemService.GetItemEditModelAsync(id);

            if (model == null)
            {
                return NotFound();
            }
            if (userId != model.PublisherId && !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpPost]
        [Authorize]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(ItemEditViewModel model)
        {
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }
            var isModerator = User.IsInRole("Moderator");
            if (GetUserId() != model.PublisherId && !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }
            if (!ModelState.IsValid)
            {
                model = await itemService.GetItemEditModelAsync(model.ItemId);
                return View(model);
            }
            try
            {
                await itemService.EditItemAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("Item", "An error occurred while editing the item.");
                return View(model);
            }
            
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await itemService.GetItemDeleteModelAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            var isModerator = User.IsInRole("Moderator");
            if (GetUserId() != model.PublisherId && !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }
            
            return View(model);
        }
        [HttpPost]
        [Authorize]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Delete(ItemDeleteViewModel model)
        {
            var isModerator = User.IsInRole("Moderator");
            if (GetUserId() != model.PublisherId && !isModerator)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                await itemService.SoftDeleteItemAsync(model.ItemId);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                ModelState.AddModelError("Item", "An error occurred while deleting the item.");
                return View(model);
            }
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
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> HardDelete(int id)
        {
            await itemService.DeleteItemAsync(id);

            return RedirectToAction(nameof(DeletedItems));
        }


    }
}
