namespace GamerMarketApp.Data.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object Id);
        Task AddAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(object Id);
        Task SaveAsync();
        IQueryable<T> GetAllAttached();
    }
}
