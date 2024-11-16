using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CinemaApp.Commons.EntityValidationConstants.ItemCategory;

namespace GamerMarket.Data.Models
{
    public class TypeCategory
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(ItemType))]
        public int TypeId { get; set; }
        [Required]
        public ItemType ItemType { get; set; } = null!;

    }
}
