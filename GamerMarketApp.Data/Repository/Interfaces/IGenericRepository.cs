using System.Linq.Expressions;

namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        IQueryable<T> GetAllAttached();
        Task SaveAsync();
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
