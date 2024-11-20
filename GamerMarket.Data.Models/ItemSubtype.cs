using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GamerMarketApp.Commons.EntityValidationConstants.ItemSubtype;

namespace GamerMarket.Data.Models
{
    public class ItemSubtype
    {
        [Key]
        public int SubtypeId { get; set; }
        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(ItemType))]
        public int ItemTypeId { get; set; }
        [Required]
        public ItemType ItemType { get; set; } = null!;

    }
}
