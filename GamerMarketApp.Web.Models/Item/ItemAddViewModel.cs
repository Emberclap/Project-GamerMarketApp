using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GamerMarketApp.Commons.EntityValidationConstants.Item;
using static GamerMarketApp.Commons.EntityValidationMessages.Item;


namespace GamerMarketApp.Web.ViewModels.Item
{
    public class ItemAddViewModel
    {
        [Key]
        public int ItemId { get; set; }
        [Required(ErrorMessage = NameRequiredMessage)]
        [StringLength(NameMaxValue, MinimumLength =NameMinValue)]
        public string Name { get; set; } = null!;

        [StringLength(DescriptionMaxValue, MinimumLength =DescriptionMinValue)]
        public string? Description { get; set; }
        [Required(ErrorMessage = ImageRequiredMessage)]
        public string ImageUrl { get; set; } = null!;
        public int SubtypeId { get; set; }
        public int GameId { get; set; }
        [Required(ErrorMessage = AddedOnDateFormatMessage)]
        [RegularExpression(@"\d{2}/\d{2}/\d{4}")]
        public string AddedOn { get; set; } = null!;

        [Precision(18, 2)]
        [Range(PriceMinValue, PriceMaxValue, ErrorMessage = IncorrectPriceMessage)]
        public decimal Price { get; set; }
        public IEnumerable<Data.Models.Game> Games { get; set; } = [];
        public IEnumerable<ItemSubtype> ItemSubtypes { get; set; } = [];
    }
}
