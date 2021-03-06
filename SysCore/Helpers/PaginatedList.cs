
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SysCore.Helpers
{
    public class PaginatedList<T> : List<T> where T: class
    {
        public PaginatedList(List<T> items, int count, int page, int pageSize)
        {
            PageIndex = page;
            TotalPages = (int) Math.Ceiling(count / (double) pageSize);
            TotalCount = count;
            AddRange(items);
        }

        public PaginatedList()
        {
            
        }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PaginatedList<T>> GetPaged(
            IQueryable<T> source, int pageIndex, int pageSize,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderedQuery = null,
            Expression<Func<T, bool>> filter = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> include = null)
        {
            // source query which implemented IQuerable
            var query = source;
            
            // A expression tree accepts a lambda expression
            if (filter != null) query = query.Where(filter);
            
            // orderedQuery is a delegate that accept a IQueryable as parameter and outputs IOrderedQueryable.
            // In this example, query is a parameter, executes the lambda expression function
            if (orderedQuery != null) query = orderedQuery(query);
            
            //Assign Lambda expressions Includes to Expression Tree
            if (include != null)
                query = include(query);

            var count = await query.CountAsync();
            var items = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}