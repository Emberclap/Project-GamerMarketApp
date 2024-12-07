using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GamerMarketApp.Commons.EntityValidationConstants.Game;


namespace GamerMarketApp.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        [MaxLength(TitleMaxValue)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;
        [MaxLength(GameImageUrlMaxValue)]
        public string? ImageUrl { get; set; }

        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        [Required]
        public Genre Genre { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public virtual ICollection<Item> Items { get; set; } = new HashSet<Item>();
    }
}
