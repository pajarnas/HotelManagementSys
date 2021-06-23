using System.Threading.Tasks;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysCore.Entities;
namespace SysCore.RepositoryInterfaces
{
    public interface ICustomerRepo : IAsyncCRUDRepo<Customer>
    {
        Task<Customer> GetByEmailAsync(string bookRequestEmail);
    }
}