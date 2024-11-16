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
    }
}
