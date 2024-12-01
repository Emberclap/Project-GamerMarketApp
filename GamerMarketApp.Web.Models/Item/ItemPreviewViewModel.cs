using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Web.ViewModels.Item
{
    public class ItemPreviewViewModel
    { 
        public int ItemId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string Publisher {  get; set; }
        public required string Subtype { get; set; }
        public required string Game { get; set; }
        public required string Price { get; set; }
        public bool IsInWatchlist { get; set; }
    }
}
