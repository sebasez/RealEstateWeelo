using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstateWeelo.Entities.Interfaces;
using RealEstateWeelo.Repository.DataContext;
using RealEstateWeelo.Repository.Repositories;

namespace RealEstateWeelo.Repository
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RealEstateWeeloContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("RealEstateWeelo")) 
            );
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IPropertyImageRepository, PropertyImageRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
