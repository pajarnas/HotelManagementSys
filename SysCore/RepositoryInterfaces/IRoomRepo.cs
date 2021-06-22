using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysCore.Entities;
namespace SysCore.RepositoryInterfaces
{
    public interface IRoomRepo : IPaginatedRepo<Room>,IAsyncCRUDRepo<Room>,IRelationRepo<Room>
    {
        
    }
}