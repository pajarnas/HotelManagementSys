using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SysInfrastructure.DataContext;
using Microsoft.EntityFrameworkCore.Query;


namespace SysInfrastructure.Repositories.BaseRepositories
{
    public class EfRelationalCrudRepo<T> : EfCrudRepo<T>, IRelationRepo<T> where T : class
    {
        public async Task<T>  GetByIdWithIncludesAsync(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IIncludableQueryable<T, object>> include)
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (include != null)
                query = include(query);
            
            if (filter != null)
                query = query.Where(filter);

            return await query.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ListWithIncludesAsync( Func<IQueryable<T>, IIncludableQueryable<T, object>> include,Expression<Func<T, bool>> filter)
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (include != null)
                query = include(query);
            
            if (filter != null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }

        public EfRelationalCrudRepo(HotelMSDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}