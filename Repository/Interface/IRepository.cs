using System.Linq.Expressions;

namespace Salus_2._0.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        Task Delete(int id);
        Task<bool> SaveChangesAsync();
    }
}
