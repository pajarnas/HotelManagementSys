using SysCore.Entities;
using SysCore.RepositoryInterfaces;
using SysCore.ServiceInterfaces;
using SysInfrastructure.Repositories;
using SysInfrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace SysInfrastructure.Helper
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepo, CustomerRepo>();
           
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
             


        }
    }
}