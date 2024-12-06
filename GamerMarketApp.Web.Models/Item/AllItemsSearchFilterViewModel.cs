namespace GamerMarketApp.Web.ViewModels.Item
{
    public class AllItemsSearchFilterViewModel
    {
        public IEnumerable<ItemPreviewViewModel>? Items { get; set; }
        public string? SearchQuery { get; set; }

        public string? GameFilter { get; set; }
        public string? TypeFilter { get; set; }

        public IEnumerable<string>? AllGames { get; set; }
        public IEnumerable<string>? AllTypes { get; set; }

        public int? CurrentPage { get; set; } = 1;

        public int? EntitiesPerPage { get; set; } = 20;

        public int? TotalPages { get; set; }
    }
}
