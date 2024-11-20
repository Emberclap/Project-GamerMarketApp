using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Genre;

namespace GamerMarketApp.Data.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Game> Games { get; } = new HashSet<Game>();
    }
}