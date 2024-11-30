using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GamerMarketApp.Data.Models
{
    [PrimaryKey(nameof(ItemId), nameof(UserId))]
    public class UserItem
    {
        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        [Required]
        public Item Item { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        [Required]
        public IdentityUser User { get; set; } = null!;
    }
}
