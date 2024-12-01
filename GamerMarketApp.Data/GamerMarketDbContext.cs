using GamerMarketApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GamerMarketApp.Data
{
    public class GamerMarketDbContext : IdentityDbContext
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole
                 {
                     Id = "1",
                     Name = "Admin",
                     NormalizedName = "ADMIN"
                 });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", // User's ID
                        RoleId = "1"  // Role's ID
                    }
                );
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
