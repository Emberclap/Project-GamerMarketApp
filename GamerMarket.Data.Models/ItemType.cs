using System.ComponentModel.DataAnnotations;
using static CinemaApp.Commons.EntityValidationConstants.Genre;

namespace GamerMarket.Data.Models
{
    public class ItemType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;


        public virtual ICollection<ItemCategory> ItemCategories { get; set; }  = new HashSet<ItemCategory>();
        public virtual ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}