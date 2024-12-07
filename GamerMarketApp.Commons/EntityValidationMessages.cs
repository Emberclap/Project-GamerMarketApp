namespace GamerMarketApp.Commons
{
    public static class EntityValidationMessages
    {

        public static class Game
        {
            public const string TitleLengthMessage = "Title must be between 3 and 50 characters.";
            public const string DescriptionLengthMessage = "Description must be between 25 and 1000 characters.";
            public const string TitleRequiredMessage = "Game Title is required.";
            public const string DescriptionRequiredMessage = "Description is required.";
            public const string ImageUrlLengthMessage = $"Url must be between 8 and 2100 characters.";

        }

        public static class Item
        {
            public const string NameLengthMessage = "Title must be between 2 and 70 characters.";
            public const string DescriptionLengthMessage = "Description must be between 5 and 500 characters.";
            public const string NameRequiredMessage = "Item Name is required.";
            public const string ImageRequiredMessage = "Item Image is required.";
            public const string AddedOnDateFormatMessage = "Invalid date format. Use 'dd/MM/yyyy'.";
            public const string IncorrectPriceMessage = "Price should be positive number!";
            public const string ImageUrlLengthMessage = $"Url must be between 8 and 2100 characters.";

        }

    }
}
