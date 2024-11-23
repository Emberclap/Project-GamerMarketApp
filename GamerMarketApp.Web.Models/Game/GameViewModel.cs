namespace GamerMarketApp.Web.ViewModels.Game
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? ImageUrl { get; set; }
        public required string Description { get; set; } = null!;
        public required string Genre { get; set; }
    }
}
