using GamerMarketApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerMarketApp.Services.Data.Interfaces
{
    public interface IDropdownService
    {
        Task<IEnumerable<Genre>> GetGenresAsync();
        Task<IEnumerable<Game>> GetGamesAsync();
        Task<IEnumerable<ItemSubtype>> GetItemSubtypesAsync();
    }
}
