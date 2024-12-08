using GamerMarketApp.Web.ViewModels.Admin.Role;
using GamerMarketApp.Web.ViewModels.Admin.User;
using Microsoft.AspNetCore.Identity;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UsersViewModel>> GetAllUsersAsync();
        Task<bool> CheckUserByIdAsync(string userId);
        Task<IdentityResult> AssignUserRoleAsync(string userId, string role);
        Task<IdentityResult> RemoveUserRoleAsync(string userId, string role);
        Task<IdentityResult> DeleteUserAsync(string userId);
        Task<IdentityResult> DisableUserAsync(string userId);
        Task<IdentityResult> EnableUserAsync(string userId);

        Task AddRoleAsync(string roleName);
        Task<RoleViewModel?> GetRolesAsync();
        Task DeleteRoleAsync(string roleName);
    }
}
