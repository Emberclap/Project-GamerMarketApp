using GamerMarketApp.Services.Data;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.Controllers;
using GamerMarketApp.Web.ViewModels.Admin.Role;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GamerMarketApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserManagementController(IUserService userService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var model = await userService.GetAllUsersAsync();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string role)
        {
            bool user = await userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return RedirectToAction(nameof(Index));
            }

            await userService.AssignUserRoleAsync(userId, role);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveRole(string userId, string role)
        {
            bool user = await userService
               .CheckUserByIdAsync(userId);
            if (!user)
            {
                return RedirectToAction(nameof(Index));
            }

            await userService.RemoveUserRoleAsync(userId, role);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(string userId)
        {
           
            bool user = await userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return RedirectToAction(nameof(Index));
            }

            await userService.DeleteUserAsync(userId);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DisableUser(string userId)
        {

            bool user = await userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return RedirectToAction(nameof(Index));
            }
            await userService.DisableUserAsync(userId);
            return this.RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> EnableUser(string userId)
        {

            bool user = await userService
                .CheckUserByIdAsync(userId);
            if (!user)
            {
                return RedirectToAction(nameof(Index));
            }
            await userService.EnableUserAsync(userId);
            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var model = await userService.GetRolesAsync();
             return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await userService.AddRoleAsync(model.Name!);
            return this.RedirectToAction(nameof(GetRoles));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRole(RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await userService.DeleteRoleAsync(model.Name!);
            return this.RedirectToAction(nameof(GetRoles));
        }
    }
}
