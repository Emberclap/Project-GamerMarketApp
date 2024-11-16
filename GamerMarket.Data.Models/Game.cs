using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GamerMarket.Data.Models
{
    using static CinemaApp.Commons.EntityValidationConstants.Game;
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        [Required]
        public Genre Genre { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
