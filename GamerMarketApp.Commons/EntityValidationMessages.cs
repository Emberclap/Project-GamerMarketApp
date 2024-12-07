namespace GamerMarketApp.Commons
{
    public static class EntityValidationMessages
    {
        public static class Game
        {
            public const string TitleRequiredMessage = "Game Title is required.";
            public const string DescriptionRequiredMessage = "Description is required.";
        }

        public static class Item
        {
            public const string NameRequiredMessage = "Item Name is required.";
            public const string ImageRequiredMessage = "Item Image is required.";
            public const string AddedOnDateFormatMessage = "Invalid date format. Use 'dd/MM/yyyy'.";
            public const string IncorrectPriceMessage = "Price should be positive number!";

        }

    }
}
