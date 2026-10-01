using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaskApi.Context;

namespace TaskApi.Repositories.Generic
{
    public class Repository<T> : IRepository<T> where T : class, ISoftDeletable
    {
        protected readonly TaskDbContext _taskDbContext;

        public Repository(TaskDbContext context) 
        {
            _taskDbContext = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync() 
        {
            return await _taskDbContext.Set<T>().Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate) 
        {
            return await _taskDbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<T> CreateAsync(T entity) 
        {
            await _taskDbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity) 
        {
            _taskDbContext.Set<T>().Update(entity);
            return entity;
        }

        public async Task<T> SoftDeleteAsync(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedAt = DateTime.Now;
            return entity;
        }

    }
}
