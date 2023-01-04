using CarApi.Repositories.Interfaces;
using CarApi.Repositories;
using CarApi.Services.Interfaces;
using CarApi.Services;

namespace CarApi.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMokymaiServices(this IServiceCollection services)
        {

            if(services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ICarAdapter, CarAdapter>();
            services.AddTransient<ICarLeasingService, CarLeasingService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserCarRepository, UserCarRepository>();
            services.AddTransient<IUserCarService, UserCarService>();

            return services;
        }
    }
}

