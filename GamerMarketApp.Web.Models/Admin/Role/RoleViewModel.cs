using System.ComponentModel.DataAnnotations;

namespace GamerMarketApp.Web.ViewModels.Admin.Role
{
    public class RoleViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; } = null!;
        public IEnumerable<string> Roles { get; set; } = new List<string>();
    }
}
