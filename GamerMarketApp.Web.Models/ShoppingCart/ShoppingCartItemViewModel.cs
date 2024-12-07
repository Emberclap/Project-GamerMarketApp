using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Web.ViewModels.ShoppingCart
{
    public class ShoppingCartItemViewModel
    {
        public int ItemId { get; set; }
        public required string Name { get; set; }
        public required string Subtype { get; set; }
        public decimal Price { get; set; }
    }
}
