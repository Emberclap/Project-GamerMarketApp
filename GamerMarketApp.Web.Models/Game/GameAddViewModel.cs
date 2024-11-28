using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Game;
using GamerMarketApp.Data.Models;



namespace GamerMarketApp.Web.ViewModels.Game
{
    public class GameAddViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(TitleMaxValue, MinimumLength = TitleMinValue)]
        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }

        [Required]
        [StringLength(DescriptionMaxValue, MinimumLength = DescriptionMinValue)]
        public string Description { get; set; } = null!;
        public int GenreId { get; set; }

        public List<Genre> Genres { get; set; } = [];
    }
}
