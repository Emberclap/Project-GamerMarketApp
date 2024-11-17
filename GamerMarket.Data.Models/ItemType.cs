﻿using System.ComponentModel.DataAnnotations;
using static CinemaApp.Commons.EntityValidationConstants.Genre;

namespace GamerMarket.Data.Models
{
    public class ItemType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(NameMaxValue)]
        public string Name { get; set; } = null!;


        public virtual ICollection<ItemSubtype> ItemSubtypes { get; set; }  = new HashSet<ItemSubtype>();
        public virtual ICollection<Item> Items { get; } = new HashSet<Item>();
    }
}