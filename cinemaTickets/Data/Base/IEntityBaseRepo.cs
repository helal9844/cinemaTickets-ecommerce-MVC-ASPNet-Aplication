using cinemaTickets.Models;

namespace cinemaTickets.Data.Base
{
    public interface IEntityBaseRepo<T> where T : class,IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        Task<T> EditAsync(int id, T t);
        Task DeleteAsync(int id);
    }
}
