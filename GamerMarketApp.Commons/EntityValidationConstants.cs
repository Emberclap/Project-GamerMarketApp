namespace GamerMarketApp.Commons
{
    public static class EntityValidationConstants
    {
        public static class Game
        {
            public const int TitleMinValue = 3;
            public const int TitleMaxValue = 80;

            public const int DescriptionMinValue = 25;
            public const int DescriptionMaxValue = 1000;

            public const int GenreMinValue = 5;
            public const int GenreMaxValue = 25;

            public const int ImageUrlMinValue = 8;
            public const int ImageUrlMaxValue = 2100;
        }
        public static class Genre
        {
            
            public const byte NameMaxValue = 30;
        }
        public static class Item
        {
            public const byte NameMinValue = 2;
            public const byte NameMaxValue = 70;

            public const int DescriptionMinValue = 5;
            public const int DescriptionMaxValue = 500;

            public const string AddedOnFormat = "dd-MM-yyyy";
        }
        public static class ItemType
        {
            public const byte NameMinValue = 5;
            public const byte NameMaxValue = 50;
        }
        public static class ItemSubtype
        {
            public const byte NameMinValue = 2;
            public const byte NameMaxValue = 50;

            public const int DescriptionMinValue = 5;
            public const int DescriptionMaxValue = 100;
        }
    }
}
