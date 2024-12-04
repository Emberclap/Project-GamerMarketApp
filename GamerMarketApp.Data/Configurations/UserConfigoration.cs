using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace GamerMarketApp.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder
                .HasData(SeedUsers());
        }
        private static IEnumerable<IdentityUser> SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var users = new List<IdentityUser>()
        {
            new IdentityUser
            {
                Id = "a75b8366-0bac-46e0-9e94-e9cfaf771b3d",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Adminqwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            },
            new IdentityUser
            {
                Id = "edd0d843-08a0-40d8-99f3-89414603ae15",
                UserName = "Moderator",
                NormalizedUserName = "MODERATOR",
                Email = "Moderator@gmail.com",
                NormalizedEmail = "MODERATOR@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Managerqwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            },
            new IdentityUser
            {
                Id = "11b7f420-600c-4095-926f-677202d4235f",
                UserName = "User",
                NormalizedUserName = "USER",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Userqwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            },
            new IdentityUser
            {
                Id = "d5c07341-f610-4e1a-82af-792644004c7e",
                UserName = "User2",
                NormalizedUserName = "USER2",
                Email = "user2@gmail.com",
                NormalizedEmail = "USER2@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "User2qwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            }
        };
            return users;
        }
    }
}
