using System;
using System.Collections.Generic; 
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
 
namespace SysCore.RepositoryInterfaces.BaseInterfaces
{
    public interface IAsyncCRUDRepo<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> ListWithWhereAsync(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> ListWithOrderedAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderedQuery = null);
    }
}