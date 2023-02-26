using cinemaTickets.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace cinemaTickets.Data.Base
{
    public class EntityBaseRepo<T> : IEntityBaseRepo<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _appDbContext;

        public EntityBaseRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(n => n.id == id);
        }
        public async Task AddAsync(T t)
        {
            await _appDbContext.Set<T>().AddAsync(t);
        }
        public async Task EditAsync(int id, T t)
        {
            EntityEntry entity = _appDbContext.Entry<T>(t);
            entity.State = EntityState.Modified;
            
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _appDbContext.Set<T>().FirstOrDefaultAsync(p => p.id == id);
            EntityEntry entity = _appDbContext.Entry<T>(result);
            entity.State = EntityState.Deleted;
        }

    }
}
