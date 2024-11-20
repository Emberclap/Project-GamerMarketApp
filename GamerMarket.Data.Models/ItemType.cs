using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Genre;

namespace GamerMarketApp.Data.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeId { get; set; }

        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;


        public virtual ICollection<ItemSubtype> ItemSubtypes { get; set; }  = new HashSet<ItemSubtype>();
        public virtual ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}