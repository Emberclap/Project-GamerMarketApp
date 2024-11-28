namespace GamerMarketApp.Web.ViewModels.Item
{
    public class ItemDetailsViewModel
    {
        public int ItemId { get; set; }
        public required string Name { get; set; }
        public required string Publisher { get; set; }
        public string? Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string SubType { get; set; }
        public required string Game { get; set; }
        public required string AddedOn { get; set; } 
        public required string Price { get; set; } 
    }
}
