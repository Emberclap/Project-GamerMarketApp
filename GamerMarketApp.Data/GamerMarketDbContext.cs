using GamerMarketApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GamerMarketApp.Data
{
    public class GamerMarketDbContext : IdentityDbContext<IdentityUser, IdentityRole<string>, string>
    {

        public GamerMarketDbContext()
        {

        }
        public GamerMarketDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemSubtype> ItemSubtypes { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<UserItem> UsersItems { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
