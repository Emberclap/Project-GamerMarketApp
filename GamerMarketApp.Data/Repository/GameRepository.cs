using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data.Repository
{
    public class GameRepository(GamerMarketDbContext dbContext) 
        : GenericRepository<Game>(dbContext), IGameRepository
    {

        public async Task<IEnumerable<Genre>> GetGenreAsync()
        {
           return await context.Genres.ToListAsync();
        }
    }
}
