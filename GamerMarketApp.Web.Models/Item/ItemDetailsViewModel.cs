namespace GamerMarketApp.Web.ViewModels.Item
{
    public class ItemDetailsViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int SubTypeId { get; set; }
        public int GameId { get; set; }
        public string AddedOn { get; set; } = null!;
        public string Price { get; set; } = null!;
    }
}
