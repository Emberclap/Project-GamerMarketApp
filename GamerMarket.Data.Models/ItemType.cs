using System.ComponentModel.DataAnnotations;
using static CinemaApp.Commons.EntityValidationConstants.Genre;

namespace GamerMarket.Data.Models
{
    public class ItemType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;


        public virtual ICollection<TypeCategory> TypeCategories { get; set; }  = new HashSet<TypeCategory>();
        public virtual ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}