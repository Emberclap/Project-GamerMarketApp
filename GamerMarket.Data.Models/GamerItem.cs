using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GamerMarketApp.Data.Models
{
    [PrimaryKey(nameof(ItemId), nameof(GamerId))]
    public class GamerItem
    {
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        [Required]
        public Item Item { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Gamer))]
        public string GamerId { get; set; } = null!;
        [Required]
        public IdentityUser Gamer { get; set; } = null!;
    }
}
