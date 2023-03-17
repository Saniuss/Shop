using Microsoft.EntityFrameworkCore;

namespace Shop.Infrastructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Data.ShopContext _appContext;

        public Repository(Data.ShopContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _appContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _appContext.Set<T>().AddAsync(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _appContext.Set<T>().Remove(entity);
            await _appContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _appContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
