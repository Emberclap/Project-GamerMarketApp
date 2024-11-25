using Microsoft.AspNetCore.Mvc;
using GamerMarketApp.Web.ViewModels.Item;
using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(ItemAddViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            string userId = GetUserId();
            await itemService.AddItemAsync(model, userId);

            return RedirectToAction(nameof(Index));
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var item = await _context.Items.FindAsync(id);
            //if (item == null)
            //{
            //    return NotFound();
            //}
            //ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Title");
            //ViewData["SubTypeId"] = new SelectList(_context.ItemSubtypes, "SubtypeId", "Name");
            return View();
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            //if (!DateTime
            //    .TryParseExact(model.AddedOn, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
            //    out DateTime addedOn))
            //{
            //    throw new InvalidOperationException("Invalid date format.");
            //}
            //if (id != item.ItemId)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(item);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ItemExists(item.ItemId))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["GameId"] = new SelectList(_context.Games, "GameId", "Title");
            //ViewData["SubTypeId"] = new SelectList(_context.ItemSubtypes, "SubtypeId", "Name");
            return View();
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            if (id == null)
            {
                return NotFound();
            }

            return View();
        }


    }
}
