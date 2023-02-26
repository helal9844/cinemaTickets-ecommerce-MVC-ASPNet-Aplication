using cinemaTickets.Models;

namespace cinemaTickets.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> EditAsync(int id,Actor actor);
        Task DeleteAsync(int id);    
    }
}
