using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateWeelo.Presenters;
using RealEstateWeelo.Repository;
using RealEstateWeelo.UseCases;

namespace RealEstateWeelo.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRealEstateWeeloDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenters();
            return services;
        }
    }
}
