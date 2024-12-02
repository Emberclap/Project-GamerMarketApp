using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GamerMarketApp.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder
                .HasData(SeedUserRoles());
           
        }
        private IEnumerable<IdentityUserRole<string>> SeedUserRoles()
        {
            var userRoles = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    UserId = "a75b8366-0bac-46e0-9e94-e9cfaf771b3d", 
                    RoleId = "1" 
                },
                new IdentityUserRole<string>
                {
                    UserId = "edd0d843-08a0-40d8-99f3-89414603ae15",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "11b7f420-600c-4095-926f-677202d4235f",
                    RoleId = "3"
                }
            };
            return userRoles;
        }
    }
}
