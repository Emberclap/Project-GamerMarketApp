
using GamerMarket.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data
{
    public class GamerMarketDbContext : IdentityDbContext
    {

        public GamerMarketDbContext()
        {
            
        }
        public GamerMarketDbContext(DbContextOptions<GamerMarketDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<TypeCategory> ItemCategories { get; set; }
        public virtual DbSet<ItemType> ItemsTypes { get; set; }
        public virtual DbSet<GamerItem> GamersItems { get; set; }
    }
}
