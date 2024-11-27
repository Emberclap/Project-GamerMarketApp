using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Item;

namespace GamerMarketApp.Web.ViewModels.Item
{
    public class ItemAddViewModel
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        [StringLength(NameMaxValue, MinimumLength =NameMinValue)]
        public string Name { get; set; } = null!;

        [StringLength(DescriptionMaxValue, MinimumLength =DescriptionMinValue)]
        public string? Description { get; set; }
        [Required]
        public string ImageUrl { get; set; } = null!;
        public int SubtypeId { get; set; }
        public int GameId { get; set; }
        [Required]
        [RegularExpression(@"\d{2}-\d{2}-\d{4}", ErrorMessage = "Invalid date format. Use 'dd-MM-yyyy'.")]
        public string AddedOn { get; set; } = null!;

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public List<Data.Models.Game> Games { get; set; } = [];
        public List<ItemSubtype> ItemSubtypes { get; set; } = [];
    }
}
