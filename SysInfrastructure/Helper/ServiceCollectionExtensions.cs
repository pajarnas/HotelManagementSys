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
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IRoomService, RoomService>();


        }
    }
}