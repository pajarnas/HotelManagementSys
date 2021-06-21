using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SysCore.Helpers;
 

namespace SysCore.RepositoryInterfaces.BaseInterfaces
{
    public interface IPaginatedRepo<T> where T : class
    {
        Task<PaginatedList<T>> GetPagedDataAsync(int pageIndex, int pageSize, IQueryable<T> source,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderedQuery = null, Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> include = null);
    }
}
 