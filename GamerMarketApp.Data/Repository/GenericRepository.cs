using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace GamerMarketApp.Data.Repository
{
    public class GenericRepository<T>(GamerMarketDbContext dbContext) : IGenericRepository<T> where T : class
    {
        protected readonly GamerMarketDbContext context = dbContext;
        protected readonly DbSet<T> dbSet = dbContext.Set<T>();

        public async Task AddAsync(T Entity)
        {
            await dbSet.AddAsync(Entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(object Id)
        {
            var entity = await dbSet.FindAsync(Id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
            await SaveAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public IQueryable<T> GetAllAttached()
        {
            return this.dbSet.AsQueryable();
        }

        public async Task<T?> GetByIdAsync(object Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T Entity)
        {
            dbSet.Update(Entity);
            await SaveAsync();
        }
    }
}
