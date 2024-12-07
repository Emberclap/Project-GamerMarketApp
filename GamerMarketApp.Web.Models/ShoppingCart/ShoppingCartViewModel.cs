using GamerMarketApp.Data.Models;
using GamerMarketApp.Web.ViewModels.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Web.ViewModels.Cart
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItemViewModel> CartItems { get; set; } = new List<ShoppingCartItemViewModel>();
        public decimal? TotalPrice { get; set; }
        public int? TotalQuantity { get; set; }

    }
}
