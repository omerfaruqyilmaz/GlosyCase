using System.Linq.Expressions;

namespace CaseAPI.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetAllPagination(int page, int pageSize, Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
