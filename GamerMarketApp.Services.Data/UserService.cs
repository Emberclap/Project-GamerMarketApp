using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GamerMarketApp.Web.ViewModels.Admin.User;
using System.Data;

namespace GamerMarketApp.Services.Data
{

    public class UserService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole<string>> roleManager) : IUserService
    {
        private readonly UserManager<IdentityUser> userManager = userManager;
        private readonly RoleManager<IdentityRole<string>> roleManager = roleManager;

        public async Task<bool> AssignUserRoleAsync(string userId, string role)
        {
            var user = await userManager
                .FindByIdAsync(userId);

            bool roleExists = await this.roleManager.RoleExistsAsync(role);

            if (user == null || !roleExists)
            {
                return true;
            }

            bool alreadyInRole = await this.userManager.IsInRoleAsync(user, role);

            if (!alreadyInRole)
            {
                var result = await this.userManager
                    .AddToRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }


        public async Task<bool> CheckUserByIdAsync(string userId)
        {
            var user = await this.userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await userManager
                .FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            var result = await this.userManager
                .DeleteAsync(user);
            if (!result.Succeeded)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> DisableUserAsync(string userId)
        {
            var user = await this.userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            await userManager.SetLockoutEnabledAsync(user, true);
            return true;
        }

        public async Task<bool> EnableUserAsync(string userId)
        {
            var user = await this.userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            await userManager.SetLockoutEndDateAsync(user, DateTime.Now);
            return true;
        }

        public async Task<IEnumerable<UsersViewModel>> GetAllUsersAsync()
        {
            var users = await this.userManager.Users
                .ToArrayAsync();

            var usersViewModel = new List<UsersViewModel>();
           

            foreach (var user in users)
            {
                IEnumerable<string> roles = await this.userManager.GetRolesAsync(user);

                usersViewModel.Add(new UsersViewModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = roles,
                });
            }
            return usersViewModel;
        }

        public async Task<bool> RemoveUserRoleAsync(string userId, string role)
        {
            var user = await userManager
                 .FindByIdAsync(userId);

            bool roleExists = await this.roleManager.RoleExistsAsync(role);

            if (user == null || !roleExists)
            {
                return false;
            }

            bool alreadyInRole = await this.userManager.IsInRoleAsync(user, role);

            if (alreadyInRole)
            {
                var result = await this.userManager
                    .RemoveFromRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
