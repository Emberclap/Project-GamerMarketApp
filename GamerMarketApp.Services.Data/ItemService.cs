using GamerMarketApp.Data.Models;
using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Services.Data.Interfaces;
using GamerMarketApp.Web.ViewModels.Item;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static GamerMarketApp.Commons.EntityValidationConstants.Item;

namespace GamerMarketApp.Services.Data
{
    public class ItemService(IItemRepository itemRepository) : IItemService
    {

        public async Task AddItemAsync(ItemAddViewModel model, string userId)
        {
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }

            var Item = new Item()
            {
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Name = model.Name,
                SubtypeId = model.SubtypeId,
                AddedOn = addedOn,
                GameId = model.GameId,
                PublisherId = userId,
                Price = model.Price
            };
            await itemRepository.AddAsync(Item);
        }

        public async Task DeleteItemAsync(int id)
        {
            var entity = await itemRepository
                .FirstOrDefaultAsync(i => i.ItemId == id);
            await itemRepository.DeleteAsync(entity);
        }

        public async Task EditItemAsync(ItemEditViewModel model)
        {
            if (model == null)
            {
                return;
            }
            if (!DateTime
                .TryParseExact(model.AddedOn, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime addedOn))
            {
                throw new InvalidOperationException("Invalid date format.");
            }
            var entity = new Item()
            {
                ItemId = model.ItemId,
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = addedOn,
                GameId = model.GameId,
                Price = model.Price,
                PublisherId = model.PublisherId,
                SubtypeId = model.SubtypeId,
            };
            await itemRepository.UpdateAsync(entity);

        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetAllItemsAsync(string userId, AllItemsSearchFilterViewModel inputModel)
        {
            inputModel.AllGames = await itemRepository.GetAllAttached().Select(g => g.Game.Title).Distinct().ToListAsync();
            inputModel.AllTypes = await itemRepository.GetAllAttached().Select(t => t.Subtype.Name).Distinct().ToListAsync();

            var itemsQuery = itemRepository
               .GetAllAttached()
               .Where(i => i.IsDeleted == false);


            if (!String.IsNullOrWhiteSpace(inputModel.SearchQuery))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.Name.ToLower().Contains(inputModel.SearchQuery.ToLower()));
            }
            if (!String.IsNullOrWhiteSpace(inputModel.GameFilter))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.Game.Title.ToLower() == inputModel.GameFilter.ToLower());
            }
            if (!String.IsNullOrWhiteSpace(inputModel.TypeFilter))
            {
                itemsQuery = itemsQuery
                    .Where(i => i.Subtype.Name.ToLower() == inputModel.TypeFilter);
            }
            inputModel.TotalPages = (int)Math.Ceiling((double)itemsQuery.Count() / inputModel.EntitiesPerPage);

            return await itemsQuery
               .Include(i => i.UserItems)
               .Where(i => i.IsDeleted == false)
               .Select(i => new ItemPreviewViewModel()
               {
                   ItemId = i.ItemId,
                   Name = i.Name,
                   Description = i.Description,
                   Game = i.Game.Title,
                   ImageUrl = i.ImageUrl,
                   Subtype = i.Subtype.Name,
                   Publisher = i.Publisher.UserName!,
                   Price = i.Price.ToString("# ###.00"),
                   IsInWatchlist = i.UserItems.Any(ui => ui.UserId == userId)
               })
               .Skip(inputModel.EntitiesPerPage * (inputModel.CurrentPage - 1))
               .Take(inputModel.EntitiesPerPage)
               .ToListAsync();
        }

        public async Task<ItemAddViewModel> GetItemAddModelAsync()
        {
            var model = new ItemAddViewModel()
            {
                Games = await itemRepository.GetGamesAsync(),
                ItemSubtypes = await itemRepository.GetItemSubtypesAsync()
            };
            return model;
        }

        public async Task<ItemDeleteViewModel?> GetItemDeleteModelAsync(int id)
        {
            var entity = await itemRepository.GetAllAttached()
                .Include(g => g.Game)
                .Where(i => !i.IsDeleted)
                .Select(i => new ItemDeleteViewModel()
            {
                ItemId = i.ItemId,
                Name = i.Name,
                ImageUrl = i.ImageUrl,
                Description = i.Description,
                Game = i.Game.Title,
                Price = i.Price.ToString("# ###.00"),
                AddedOn = i.AddedOn.ToString("dd/MM/yyyy"),
                SubType = i.Subtype.Name,
                Publisher = i.Publisher.UserName!,
                PublisherId = i.Publisher.Id,

                })
            .FirstOrDefaultAsync(g => g.ItemId == id);
            return entity;
        }

        public async Task<ItemDetailsViewModel?> GetItemDetailsAsync(string userId,int id)
        {
            return await itemRepository.GetAllAttached()
               .Include(i => i.UserItems)
               .Where(i => i.IsDeleted == false && i.ItemId == id)
               .Select(i => new ItemDetailsViewModel()
               {
                   ItemId = i.ItemId,
                   Name = i.Name,
                   Description = i.Description,
                   Game = i.Game.Title,
                   Publisher = i.Publisher.UserName,
                   ImageUrl = i.ImageUrl,
                   SubType = i.Subtype.Name,
                   Price = i.Price.ToString("# ###.00"),
                   AddedOn = i.AddedOn.ToString("dd/MM/yyyy"),
                   IsInWatchlist = i.UserItems.Any(ui => ui.UserId == userId)
               })
               .FirstOrDefaultAsync(g => g.ItemId == id);
        }

        public async Task<ItemEditViewModel> GetItemEditModelAsync(int id)
        {
            var item = await itemRepository.FirstOrDefaultAsync(g => g.ItemId == id);

            var model = new ItemEditViewModel()
            {
                ItemId = item.ItemId,
                Name = item.Name,
                AddedOn = item.AddedOn.ToString("dd/MM/yyyy"),
                Description = item.Description,
                ImageUrl = item.ImageUrl,
                Price = item.Price,
                GameId = item.GameId,
                SubtypeId = item.SubtypeId,
                PublisherId = item.PublisherId,
            };
            model.Games = (List<Game>)await itemRepository.GetGamesAsync();
            model.ItemSubtypes = (List<ItemSubtype>)await itemRepository.GetItemSubtypesAsync();
            return model;
        }

        public async Task SoftDeleteItemAsync(int id)
        {
            var entity = await itemRepository.GetByIdAsync(id);

            entity.IsDeleted = true;

            await itemRepository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetAllDeletedItemsAsync()
        {
            return await itemRepository.GetAllAttached()
                .Where(i => i.IsDeleted == true)
                .Select(i => new ItemPreviewViewModel()
                {
                    ItemId = i.ItemId,
                    Name = i.Name,
                    ImageUrl = i.ImageUrl,
                    Game = i.Game.Title,
                    Description = i.Description,
                    Price = i.Price.ToString("# ###.00"),
                    Subtype = i.Subtype.Name,
                    Publisher = i.Publisher.UserName!,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ItemPreviewViewModel>> GetHomeItemsAsync()
        {
            return await itemRepository.GetAllAttached()
                 .Where(i => i.IsDeleted == false)
                 .OrderByDescending(i => i.Price)
                 .Select(i => new ItemPreviewViewModel()
                 {
                     ItemId = i.ItemId,
                     Name = i.Name,
                     ImageUrl = i.ImageUrl,
                     Game = i.Game.Title,
                     Description = i.Description,
                     Price = i.Price.ToString("# ###.00"),
                     Subtype = i.Subtype.Name,
                     Publisher = i.Publisher.UserName!,
                 })
                 .Take(3)
                 .ToListAsync();
        }
    }
}
