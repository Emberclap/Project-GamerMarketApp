using GamerMarketApp.Data.Models;
using GamerMarketApp.Web.ViewModels.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IItemRepository : IGenericRepository<Item>
    {
        Task<IEnumerable<Game>> GetGamesAsync();
        Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync();
        Task<ItemDetailsViewModel?> GetItemDetailsAsync(int id);

    }
}
