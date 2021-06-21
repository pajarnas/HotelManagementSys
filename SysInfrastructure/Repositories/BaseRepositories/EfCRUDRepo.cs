using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using System.Threading.Tasks;
using SysCore.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SysInfrastructure.DataContext;

namespace SysInfrastructure.Repositories.BaseRepositories
{
    public class EfCRUDRepo<T>: IAsyncCRUDRepo<T> where T:class
    {
        protected readonly HotelMSDbContext _dbContext;
        
        public EfCRUDRepo(HotelMSDbContext dbContext)
        {
           
            _dbContext = dbContext;
        }
        
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        
        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> ListWithWhereAsync(Expression<Func<T, bool>> filter)
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> ListWithOrderedAsync(Func<IQueryable<T>, IOrderedQueryable<T>> orderedQuery = null)
        {
            var query = _dbContext.Set<T>().AsQueryable();

            if (orderedQuery != null)
                query = orderedQuery(query);

            return await query.ToListAsync();
        }
        
        public virtual async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return  entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        
        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter)
        {
            if (filter != null)
                return await _dbContext.Set<T>().Where(filter).CountAsync();
            return await _dbContext.Set<T>().CountAsync();
        }

        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter)
        {
            if (filter == null) return false;
            return await _dbContext.Set<T>().Where(filter).AnyAsync();
        }

    }
}


