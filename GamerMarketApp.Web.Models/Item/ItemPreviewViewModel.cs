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
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int SubTypeId { get; set; }
        public int GameId { get; set; }
        public string AddedOn { get; set; } = null!;
        public string Price { get; set; } = null!;
    }
}
