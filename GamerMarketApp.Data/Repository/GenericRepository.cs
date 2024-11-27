using GamerMarketApp.Data.Repository.Interfaces;
using GamerMarketApp.Data.Models;

using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GamerMarketApp.Data.Repository
{
    public class GenericRepository<T>(GamerMarketDbContext dbContext) : IGenericRepository<T> where T : class
    {
        protected readonly GamerMarketDbContext context = dbContext;
        protected readonly DbSet<T> dbSet = dbContext.Set<T>();

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            this.dbSet.Remove(entity);
            await SaveAsync();

            return true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public IQueryable<T> GetAllAttached()
        {
            return this.dbSet.AsQueryable().AsNoTracking();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);

        }

        public async Task<bool> UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            await SaveAsync();
            return true;
        }
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await this.dbSet
                .FirstOrDefaultAsync(predicate);

            return entity;
        }
    }
}
