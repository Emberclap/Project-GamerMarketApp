using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Game;
using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Services.Data
{
    public class GameService(IGameRepository gameRepository) : IGameService
    {
        private readonly IGameRepository gameRepository = gameRepository;
        //private readonly IDropdownService dropdownService = dropdownService;

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
                .ToListAsync();
        }
        public async Task<GameAddViewModel> GetAddModelAsync()
        {
            var model = new GameAddViewModel()
            {
                Genres = (List<Genre>)await gameRepository.GetGenreAsync()
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
            var game = await gameRepository
                .FirstOrDefaultAsync(g => g.GameId == id && g.IsDeleted == false);

            var model = new GameAddViewModel()
            {
                Id = game!.GameId,
                Title = game.Title,
                Description = game.Description,
                ImageUrl = game.ImageUrl,
                GenreId = game.GenreId
            };

            model.Genres = (List<Genre>)await gameRepository.GetGenreAsync();

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
            var gameToDelete = await gameRepository
                .FirstOrDefaultAsync(g => g.GameId == id && !g.IsDeleted);

            var model = new GameConfirmDeleteViewModel()
            {
                Id = gameToDelete!.GameId,
                Title = gameToDelete.Title,
                ImageUrl = gameToDelete.ImageUrl
            };
            return model;
        }

        public async Task<GameDeleteViewModel?> GetGameDeleteModelAsync(int id)
        {
            var model = await gameRepository.GetAllAttached()
                .Where(g => g.IsDeleted == false)
                .Select(g => new GameDeleteViewModel
            {
                    Id = g.GameId,
                    Title = g.Title,
                    ImageUrl = g.ImageUrl,
                    Description = g.Description,
                    Genre = g.Genre.Name
                })
                .FirstOrDefaultAsync(g => g.Id == id);

            return model;
        }

        public async Task DeleteGameAsync(GameConfirmDeleteViewModel model)
        {
            var gameEntity = await gameRepository.GetByIdAsync(model.Id);
            if (gameEntity == null)
            {
                return;
            }
            await gameRepository.DeleteAsync(gameEntity);

        }
        public async Task UndoSoftDeleteGameAsync(int id)
        {
            var gameEntity = await gameRepository.GetByIdAsync(id);
            if(gameEntity == null)
            {
                return;
            }
            gameEntity.IsDeleted = false;

            await this.gameRepository.UpdateAsync(gameEntity);
        }
        public async Task SoftDeleteGameAsync(int id)
        {
            var gameEntity = await gameRepository.GetByIdAsync(id);
            if (gameEntity == null)
            {
                return;
            }
            gameEntity.IsDeleted = true;

            await this.gameRepository.UpdateAsync(gameEntity);
        }

    }
}
