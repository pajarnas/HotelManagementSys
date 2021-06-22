using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Room>> GetDistinctRoomsGroupByType()
        {
            var entities = await _dbContext.Set<Room>().Include(m => m.RoomType).GroupBy(m => m.RoomType,(k,c)=>new Room()
                {
                    RoomType = k,
                    Id = k.Rooms.First().Id,
                    RtCode = k.Id,
                    Status = k.Rooms.First().Status
                })
                .ToListAsync();
            return entities;
        }

        // public async Task<List<Room>> GetRoomsOrderByPrice()
        // {
        //     var entities = await _dbContext.Set<Room>().Include(m => m.RoomType).OrderBy(m => m.RoomType.Rent)
        //         .ToListAsync();
        //     return entities;
        // }
    }
}