using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GamerMarketApp.Web.Controllers
{
    
    public class BaseController : Controller
    {
        [Authorize]
        protected string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }

    }
}
