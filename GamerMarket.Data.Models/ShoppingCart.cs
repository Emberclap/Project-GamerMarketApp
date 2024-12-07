using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        [Required]
        public IdentityUser User { get; set; } = null!;
        public IEnumerable<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
