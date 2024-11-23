namespace GamerMarketApp.Web.ViewModels.Game
{
    public class GameConfirmDeleteViewModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? ImageUrl { get; set; }
    }
}
