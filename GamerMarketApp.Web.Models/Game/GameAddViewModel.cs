using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Game;
using static GamerMarketApp.Commons.EntityValidationMessages.Game;

using GamerMarketApp.Data.Models;



namespace GamerMarketApp.Web.ViewModels.Game
{
    public class GameAddViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = TitleRequiredMessage)]
        [StringLength(TitleMaxValue, MinimumLength = TitleMinValue, ErrorMessage = TitleLengthMessage)]
        public string Title { get; set; } = null!;
        [StringLength(GameImageUrlMaxValue, MinimumLength = GameImageUrlMinValue, ErrorMessage = ImageUrlLengthMessage)]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = DescriptionRequiredMessage)]
        [StringLength(DescriptionMaxValue, MinimumLength = DescriptionMinValue, ErrorMessage = DescriptionLengthMessage)]
        public string Description { get; set; } = null!;
        public int GenreId { get; set; }

        public List<Genre> Genres { get; set; } = [];
    }
}
