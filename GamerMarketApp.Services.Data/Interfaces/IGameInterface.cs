using GamerMarketApp.Web.ViewModels.Game;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IGameService
    {

        Task<GameAddViewModel> GetAddModelAsync();

        Task AddGameAsync(GameAddViewModel model);

        Task<IEnumerable<GameViewModel>> GetAllGamesAsync();

        Task<GameAddViewModel> GetEditModelAsync(int id);
        Task EditGameAsync(GameAddViewModel model);

        Task<GameDeleteViewModel?> GetDeleteModelAsync(int id);
        Task DeleteGame(GameDeleteViewModel model);

    }
}
