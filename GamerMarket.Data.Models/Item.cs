using CinemaApp.Commons;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CinemaApp.Commons.EntityValidationConstants.Item;

namespace GamerMarket.Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(EntityValidationConstants.ItemType.NameMaxValue)]
        public ItemType Type { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Publisher))]
        public string PublisherId { get; set; } = null!;
        [Required]
        public IdentityUser Publisher { get; set; } = null!;

        public DateTime AddedOn { get; set; }

        public decimal Price { get; set; }

        public bool SoldOut { get; set; }

        public bool IsDeleted { get; set; }
    }
}
