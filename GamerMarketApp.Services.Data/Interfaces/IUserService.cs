using GamerMarketApp.Web.ViewModels.Admin.User;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UsersViewModel>> GetAllUsersAsync();
        Task<bool> CheckUserByIdAsync(string userId);
        Task<bool> AssignUserRoleAsync(string userId, string role);
        Task<bool> RemoveUserRoleAsync(string userId, string role);
        Task<bool> DeleteUserAsync(string userId);
        Task<bool> DisableUserAsync(string userId);
        Task<bool> EnableUserAsync(string userId);

    }
}
