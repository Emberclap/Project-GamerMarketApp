using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Game;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Services.Data
{
    public class GameService(IGenericRepository<Game> gameRepository,
        IGenericRepository<Genre> genreRepository) : IGameService
    {
        private readonly IGenericRepository<Game> gameRepository = gameRepository;
        private readonly IGenericRepository<Genre> genreRepository = genreRepository;

        public async Task<IEnumerable<GameViewModel>> GetAllGamesAsync()
        {
            return await gameRepository.GetAllAttached()
                .Where(g => g.IsDeleted == false)
                .Select(g => new GameViewModel()
                {
                    Id = g.GameId,
                    Title = g.Title,
                    ImageUrl = g.ImageUrl,
                    Genre = g.Genre.Name,
                    Description = g.Description,
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<GameViewModel>> GetAllDeletedGamesAsync()
        {
            return await gameRepository.GetAllAttached()
                .Where(g => g.IsDeleted == true)
                .Select(g => new GameViewModel()
                {
                    Id = g.GameId,
                    Title = g.Title,
                    ImageUrl = g.ImageUrl,
                    Genre = g.Genre.Name,
                    Description = g.Description,
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<GameAddViewModel> GetAddModelAsync()
        {
            var model = new GameAddViewModel()
            {
                Genres = await GetGenres()
            };
            return model;
        }
        public async Task AddGameAsync(GameAddViewModel model)
        {
            var game = new Game()
            {
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                GenreId = model.GenreId,
            };
            await this.gameRepository.AddAsync(game);
        }

        public async Task<GameAddViewModel> GetEditModelAsync(int id)
        {
            var model = await gameRepository.GetAllAttached()
                .Where(g => g.IsDeleted == false)
                .Select(g => new GameAddViewModel
                {
                    Id = g.GameId,
                    Title = g.Title,
                    Description = g.Description,
                    ImageUrl = g.ImageUrl,
                    GenreId = g.GenreId  
                })
                .FirstOrDefaultAsync(g => g.Id == id);
            

            model.Genres = await GetGenres();

            return model;
        }
        public async Task EditGameAsync(GameAddViewModel model)
        {
           
            var gameEntity = new Game()
            {
                GameId = model.Id,
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                GenreId = model.GenreId,
            };
            await this.gameRepository.UpdateAsync(gameEntity);
        }

        public async Task<GameConfirmDeleteViewModel> GetConfirmDeleteModelAsync(int id)
        {
            var model = await gameRepository.GetAllAttached()
                .Select(g => new GameConfirmDeleteViewModel()
                {
                    Id = g.GameId,
                    Title = g.Title,
                    ImageUrl = g.ImageUrl
                })
                .FirstOrDefaultAsync(g => g.Id == id);

            return model;
        }

        public async Task<GameDeleteViewModel> GetGameDeleteModelAsync(int id)
        {
            var model = await gameRepository.GetAllAttached()
                .Where(g => g.IsDeleted == false)
                .Select(g => new GameDeleteViewModel
                {
                    Id = g.GameId,
                    Title = g.Title,
                    ImageUrl = g.ImageUrl,
                    Description = g.Description,
                    Genre = g.Genre.Name,
                })
                .FirstOrDefaultAsync(g => g.Id == id);

            return model;
        }

        public async Task DeleteGameAsync(GameConfirmDeleteViewModel model)
        {
            var gameEntity = await gameRepository.GetByIdAsync(model.Id);

            await gameRepository.DeleteAsync(gameEntity);
            
        }
        public async Task UndoSoftDeleteGameAsync(int id)
        {
            var gameEntity = await gameRepository.GetByIdAsync(id);

            gameEntity.IsDeleted = false;

            await this.gameRepository.UpdateAsync(gameEntity);
        }
        public async Task SoftDeleteGameAsync(int id)
        {
            var gameEntity = await gameRepository.GetByIdAsync(id);
            
            gameEntity.IsDeleted = true;

            await this.gameRepository.UpdateAsync(gameEntity);
        }
        private async Task<List<Genre>> GetGenres()
        {

            return (List<Genre>)await this.genreRepository.GetAllAsync();
        }
    }
}
