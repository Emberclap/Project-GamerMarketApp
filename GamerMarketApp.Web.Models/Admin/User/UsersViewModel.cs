namespace GamerMarketApp.Web.ViewModels.Admin.User
{
    public class UsersViewModel
    {
        public required string Id { get; set; }
        public string? Email { get; set; }
        public IEnumerable<string> Roles { get; set; } = new List<string>();
    }
}
