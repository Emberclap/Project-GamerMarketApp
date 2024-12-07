using GamerMarketApp.Commons;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamerMarketApp.Data.Models
{
    [PrimaryKey(nameof(ItemId), nameof(CartId))]
    public class CartItem
    {
        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }
        [Required]
        public ShoppingCart Cart { get; set; } = null!;

        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }
        [Required]
        public Item Item { get; set; } = null!;

    }
}
