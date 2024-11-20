using GamerMarketApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata.Ecma335;

namespace GamerMarketApp.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                 .HasData(this.SeedGenres());
                 
        }

        private IEnumerable<Genre> SeedGenres()
        {
            var genres = new List<Genre>()
            {
                 new Genre { GenreId = 1, Name = "Action" },
                 new Genre { GenreId = 2, Name = "Adventure" },
                 new Genre { GenreId = 3, Name = "Fighting" },
                 new Genre { GenreId = 4, Name = "Sports" },
                 new Genre { GenreId = 5, Name = "Racing" },
                 new Genre { GenreId = 6, Name = "RPG" },
                 new Genre { GenreId = 7, Name = "Survival" },
                 new Genre { GenreId = 8, Name = "MMORPG" },
                 new Genre { GenreId = 9, Name = "MOBA" },
                 new Genre { GenreId = 10, Name = "FPS" },
                 new Genre { GenreId = 11, Name = "Shooter" },
                 new Genre { GenreId = 12, Name = "Strategy" },
                 new Genre { GenreId = 13, Name = "Music video game" },
                 new Genre { GenreId = 14, Name = "Battle royale" },
                 new Genre { GenreId = 15, Name = "Sandbox" }
            };

            return genres; 
        }

    }
}
