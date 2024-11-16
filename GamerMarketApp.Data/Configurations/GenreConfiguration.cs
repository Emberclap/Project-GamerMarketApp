using GamerMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamerMarketApp.Data.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                 .HasData(
                 new Genre { Id = 1, Name = "Action" },
                 new Genre { Id = 2, Name = "Adventure" },
                 new Genre { Id = 3, Name = "Fighting" },
                 new Genre { Id = 4, Name = "Sports" },
                 new Genre { Id = 5, Name = "Racing" },
                 new Genre { Id = 6, Name = "Role-Playing game" },
                 new Genre { Id = 7, Name = "Survival" },
                 new Genre { Id = 8, Name = "MMORPG" },
                 new Genre { Id = 9, Name = "MOBA" },
                 new Genre { Id = 10, Name = "First-Person Shooter" },
                 new Genre { Id = 11, Name = "Shooter" },
                 new Genre { Id = 12, Name = "Strategy" },
                 new Genre { Id = 13, Name = "Music Video game" },
                 new Genre { Id = 14, Name = "Battle royale" },
                 new Genre { Id = 15, Name = "Sandbox" });
        }
    }
}
