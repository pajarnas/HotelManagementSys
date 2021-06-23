using SysCore.Entities;
using SysCore.RepositoryInterfaces;
using SysCore.ServiceInterfaces;
using SysInfrastructure.Repositories;
using SysInfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using SysCore.RepositoryInterfaces.BaseInterfaces;
using SysInfrastructure.Repositories.BaseRepositories;

namespace SysInfrastructure.Helper
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<IRoomRepo, RoomRepo>();
            services.AddScoped<IRelationRepo<RoomType>, EfRelationalCrudRepo<RoomType>>();
            services.AddScoped<IRelationRepo<Customer>, EfRelationalCrudRepo<Customer>>();
            services.AddScoped < IRelationRepo<Service>, EfRelationalCrudRepo<Service>>();
            services.AddScoped<IAsyncCRUDRepo<ServiceType>, EfCrudRepo<ServiceType>>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IrService, RsService>();

        }
    }
}