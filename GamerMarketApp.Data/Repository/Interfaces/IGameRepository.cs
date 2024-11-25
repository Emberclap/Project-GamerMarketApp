using GamerMarketApp.Data.Models;

namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        Task<IEnumerable<Genre>> GetGenreAsync();
    }
}