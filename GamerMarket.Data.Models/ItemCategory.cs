using System.ComponentModel.DataAnnotations;
using static CinemaApp.Commons.EntityValidationConstants.ItemCategory;

namespace GamerMarket.Data.Models
{
    public class ItemCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        public virtual ICollection<ItemType> Items { get; set; } = new HashSet<ItemType>();
    }
}
