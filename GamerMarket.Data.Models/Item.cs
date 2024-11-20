using GamerMarketApp.Commons;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GamerMarketApp.Commons.EntityValidationConstants.Item;

namespace GamerMarketApp.Data.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxValue)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;

        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }
        [Required]
        [MaxLength(EntityValidationConstants.ItemType.NameMaxValue)]
        public ItemType Type { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Publisher))]
        public string PublisherId { get; set; } = null!;
        [Required]
        public IdentityUser Publisher { get; set; } = null!;

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        [Required]
        public Game Game { get; set; } = null!;
        public DateTime AddedOn { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public bool SoldOut { get; set; }

        public bool IsDeleted { get; set; }
    }
}
