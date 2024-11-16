namespace CinemaApp.Commons
{
    public static class EntityValidationConstants
    {
        public static class Game
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 50;

            public const int DescriptionMinLength = 25;
            public const int DescriptionMaxLength = 1000;

            public const int GenreMinLength = 5;
            public const int GenreMaxLength = 20;

            public const int ImageUrlMinLength = 8;
            public const int ImageUrlMaxLength = 2100;
        }
        public static class Genre
        {
            
            public const byte NameMaxValue = 20;
        }
    }
}
