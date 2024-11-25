using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;

namespace GamerMarketApp.Services.Data
{
    public class DropdownService(IGenericRepository<ItemSubtype> itemSubtypeRepository,
        IGenericRepository<Game> gameRepository,
        IGenericRepository<Genre> genreRepository) : IDropdownService
    {
        private readonly IGenericRepository<ItemSubtype> itemSubtypeRepository = itemSubtypeRepository;
        private readonly IGenericRepository<Game> gameRepository = gameRepository;
        private readonly IGenericRepository<Genre> genreRepository = genreRepository;

        public async Task<IEnumerable<Game>> GetGamesAsync()
        {
            return await gameRepository.GetAllAsync();
        }


        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await genreRepository.GetAllAsync();

        }

        public async Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync()
        {
            return await itemSubtypeRepository.GetAllAsync();

        }
    }
}
