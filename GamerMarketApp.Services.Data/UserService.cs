using GamerMarketApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GamerMarketApp.Web.ViewModels.Admin.User;
using System.Data;
using GamerMarketApp.Web.ViewModels.Admin.Role;

namespace GamerMarketApp.Services.Data
{

    public class UserService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole<string>> roleManager) : IUserService
    {
        public async Task<IdentityResult> AssignUserRoleAsync(string userId, string role)
        {
            var user = await userManager
                .FindByIdAsync(userId);

            bool roleExists = await roleManager.RoleExistsAsync(role);

            if (user == null || !roleExists)
            {
                return IdentityResult.Failed();
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, role);

            if (!alreadyInRole)
            {
                var result = await userManager
                    .AddToRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    return IdentityResult.Failed();
                }
            }

            return IdentityResult.Success;
        }


        public async Task<bool> CheckUserByIdAsync(string userId)
        {
            var user = await userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return false;

            }
            return true;
        }

        public async Task<IdentityResult> DeleteUserAsync(string userId)
        {
            var user = await userManager
                .FindByIdAsync(userId);

            if (user == null)
            {
               return IdentityResult.Failed();
            }

            var result = await userManager
                .DeleteAsync(user!);
            if (!result.Succeeded)
            {
                return IdentityResult.Failed();
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DisableUserAsync(string userId)
        {
            var user = await userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(); ;
            }
            await userManager.SetLockoutEnabledAsync(user, true);
            await userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddYears(10));
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> EnableUserAsync(string userId)
        {
            var user = await userManager
                 .FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed();
            }
            await userManager.SetLockoutEndDateAsync(user, DateTime.Now);
            return IdentityResult.Success;
        }

        public async Task<IEnumerable<UsersViewModel>> GetAllUsersAsync()
        {
            var users = await userManager.Users
                .ToArrayAsync();

            var usersViewModel = new List<UsersViewModel>();
           

            foreach (var user in users)
            {
                IEnumerable<string> roles = await userManager.GetRolesAsync(user);

                usersViewModel.Add(new UsersViewModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = roles,
                });
            }
            return usersViewModel;
        }

        public async Task<IdentityResult> RemoveUserRoleAsync(string userId, string role)
        {
            var user = await userManager
                 .FindByIdAsync(userId);

            bool roleExists = await roleManager.RoleExistsAsync(role);

            if (user == null || !roleExists)
            {
                return IdentityResult.Failed();
            }

            bool alreadyInRole = await userManager.IsInRoleAsync(user, role);

            if (!alreadyInRole)
            {
                return IdentityResult.Failed();

            }
            var result = await userManager
                    .RemoveFromRoleAsync(user, role);
            return IdentityResult.Success;
        }

        public async Task AddRoleAsync(string roleName)
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
        public async Task<RoleViewModel?> GetRolesAsync()
        {
            var availableRoles = await roleManager
               .Roles
               .Select(r => r.Name)
               .ToListAsync();
            if (availableRoles.Count <= 0)
            {
                return null;
            }
            var model = new RoleViewModel()
            {
                Roles = availableRoles!
            };
            return model;
        }

        public async Task DeleteRoleAsync(string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role != null)
            {
                await roleManager.DeleteAsync(role);
            }
        }
    }
}
