using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Web.Areas.Admin.Controllers
{
    public class RoleManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
