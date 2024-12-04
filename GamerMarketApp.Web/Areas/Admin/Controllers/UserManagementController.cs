using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserManagementController(IUserService userService) : Controller
    {
        private readonly IUserService userService = userService;
        public async Task<IActionResult> Index()
        {
            var model = await userService.GetAllUsersAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            bool user = await this.userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return this.RedirectToAction(nameof(Index));
            }

            await this.userService.AssignUserRoleAsync(userId, role);

            return this.RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            bool user = await this.userService
               .CheckUserByIdAsync(userId);
            if (!user)
            {
                return this.RedirectToAction(nameof(Index));
            }

            await this.userService.RemoveUserRoleAsync(userId, role);
            return this.RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
           
            bool user = await this.userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return this.RedirectToAction(nameof(Index));
            }

            await this.userService.DeleteUserAsync(userId);
            return this.RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DisableUser(string userId)
        {

            bool user = await this.userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return this.RedirectToAction(nameof(Index));
            }
            await this.userService.DisableUserAsync(userId);
            return this.RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> EnableUser(string userId)
        {

            bool user = await this.userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return this.RedirectToAction(nameof(Index));
            }
            await this.userService.EnableUserAsync(userId);
            return this.RedirectToAction(nameof(Index));
        }
    }
}
