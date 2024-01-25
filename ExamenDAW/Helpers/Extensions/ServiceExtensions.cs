using ExamenDAW.Repositories.EvenimentRepository;
using ExamenDAW.Repositories.ParticipantRepository;
using ExamenDAW.Services.EvenimenteService;
using ExamenDAW.Services.ParticipantService;
using Microsoft.AspNetCore.Authorization;
namespace ExamenDAW.Helpers.Extensions
{
    public static class ServiceExtension{ 
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddTransient<IRepository, Repository>();
            services.AddTransient<IEvenimentRepository, EvenimentRepsitory>();
            services.AddTransient<IParticipantRepository, ParticipantRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //services.AddTransient<IService,Service>();
            services.AddTransient<IEvenimentService, EvenimentService>();
            services.AddTransient<IParticipantService, ParticipantService>();
            return services;
        }
    }
}
