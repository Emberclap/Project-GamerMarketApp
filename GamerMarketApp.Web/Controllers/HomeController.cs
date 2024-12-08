using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Controllers
{
    public class HomeController(IItemService itemService) 
        : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await itemService.GetHomeItemsAsync();
            return View(model);
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("NotFound");
            }
            return View("Error");
        }

    }
}
