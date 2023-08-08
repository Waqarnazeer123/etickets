using etickets.Models;

namespace etickets.Data.Base
{
    public interface IEntityBaseRepository <T> where T : class, IEntityBase, new()
    {

        Task<IEnumerable<T>> GetAllasync();
        Task<T> GetByIdasync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
