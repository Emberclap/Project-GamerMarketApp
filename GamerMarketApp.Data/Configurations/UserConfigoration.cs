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
                UserName = "testAdmin",
                NormalizedUserName = "TESTADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "AdminQwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            },
            new IdentityUser
            {
                Id = "edd0d843-08a0-40d8-99f3-89414603ae15",
                UserName = "testManager",
                NormalizedUserName = "TESTMANAGER",
                Email = "Manager@GMAIL.COM",
                NormalizedEmail = "MANAGER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "ManagerQwe123"), // Hash the password
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = true,
                AccessFailedCount = 3,
            },
            new IdentityUser
            {
                Id = "11b7f420-600c-4095-926f-677202d4235f",
                UserName = "testUser",
                NormalizedUserName = "TESTUSER",
                Email = "TESTUSER@GMAIL.COM",
                NormalizedEmail = "TESTUSER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "UserQwe123"), // Hash the password
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
