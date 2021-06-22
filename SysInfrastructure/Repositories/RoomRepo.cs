using SysCore.Entities;
using SysCore.RepositoryInterfaces;
using SysInfrastructure.DataContext;
using SysInfrastructure.Repositories.BaseRepositories;

namespace SysInfrastructure.Repositories
{
    public class RoomRepo : EfRelationalCrudPaginatedRepo<Room>, IRoomRepo
    {
        public RoomRepo(HotelMSDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}