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
        Task SoftDeleteGameAsync(int id);
        Task<GameDeleteViewModel> GetGameDeleteModelAsync(int id);
        Task DeleteGameAsync(GameConfirmDeleteViewModel model);
        Task<GameConfirmDeleteViewModel> GetConfirmDeleteModelAsync(int id);
        Task<IEnumerable<GameViewModel>> GetAllDeletedGamesAsync();
        Task UndoSoftDeleteGameAsync(int id);
    }
}
