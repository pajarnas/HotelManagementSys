using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
 
using Microsoft.EntityFrameworkCore.Query;
namespace SysCore.RepositoryInterfaces.BaseInterfaces
{
    public interface IRelationRepo<T> where T:class
    {
        Task<T> GetByIdWithIncludesAsync(int id, Expression<Func<T, bool>> filter,Func<IQueryable<T>,IIncludableQueryable<T,object>> include);
        Task<IEnumerable<T>> ListWithIncludesAsync( Func<IQueryable<T>,IIncludableQueryable<T,object>> include,Expression<Func<T, bool>> filter);
    }
}

 