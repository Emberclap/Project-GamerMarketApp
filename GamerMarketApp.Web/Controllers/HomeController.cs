using GamerMarketApp.Services.Data;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.Controllers;
using GamerMarketApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamerMarketApp.Controllers
{
    public class HomeController(IItemService itemService, ILogger<HomeController> logger) 
        : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await itemService.GetHomeItemsAsync();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
