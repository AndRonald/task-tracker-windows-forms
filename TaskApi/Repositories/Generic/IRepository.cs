using System.Linq.Expressions;

namespace TaskApi.Repositories.Generic
{
    public interface IRepository<T> where T : class, ISoftDeletable
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> CreateAsync(T entity);
        T Update(T entity);
        Task<T> SoftDeleteAsync(T entity);
    }
}
