using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SysCore.Entities;
using SysCore.RepositoryInterfaces;
using SysInfrastructure.DataContext;
using SysInfrastructure.Repositories.BaseRepositories;

namespace SysInfrastructure.Repositories
{
    public class CustomerRepo : EfCrudRepo<Customer>, ICustomerRepo
    {
        public CustomerRepo(HotelMSDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<Customer> GetByEmailAsync(string bookRequestEmail)
        {
           
            return await _dbContext.Set<Customer>().FirstOrDefaultAsync(u => u.Email == bookRequestEmail);
        }
    }
}