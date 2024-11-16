
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data
{
    public class GamerMarketDbContext : DbContext
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
