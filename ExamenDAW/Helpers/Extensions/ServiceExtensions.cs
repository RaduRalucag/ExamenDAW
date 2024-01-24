using Microsoft.AspNetCore.Authorization;
namespace ExamenDAW.Helpers.Extensions
{
    public static class ServiceExtension{ 
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            return services;
        }
    }
}
