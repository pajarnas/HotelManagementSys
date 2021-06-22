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
    }
}