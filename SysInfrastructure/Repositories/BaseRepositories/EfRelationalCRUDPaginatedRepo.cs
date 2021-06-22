using System;

using System.Linq;
using System.Linq.Expressions;

using SysCore.RepositoryInterfaces.BaseInterfaces;
using System.Threading.Tasks;
using SysCore.Helpers;
using SysInfrastructure.DataContext;


namespace SysInfrastructure.Repositories.BaseRepositories
{
    public class EfRelationalCrudPaginatedRepo<T> : EfRelationalCrudRepo<T>, IPaginatedRepo<T> where T : class
    {
        public async Task<PaginatedList<T>> GetPagedDataAsync(int pageIndex, int pageSize, IQueryable<T> source = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderedQuery = null, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> include = null)
        {
            if (source == null)
                source = _dbContext.Set<T>();
               
            return  await PaginatedList<T>.GetPaged(source, pageIndex, pageSize, orderedQuery, filter, include);;
        }

        public EfRelationalCrudPaginatedRepo(HotelMSDbContext dbContext) : base(dbContext)
        {
        }
    }
}