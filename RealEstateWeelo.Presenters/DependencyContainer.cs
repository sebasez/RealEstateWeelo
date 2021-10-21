using Microsoft.Extensions.DependencyInjection;
using RealEstateWeelo.UseCasesPorts;

namespace RealEstateWeelo.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreatePropertyImageOutputPort, CreatePropertyImagePresenter>();
            services.AddScoped<ICreatePropertyOutputPort, CreatePropertyPresenter>();
            services.AddScoped<IGetPropertiesOutputPort, GetPropertiesPresenter>();
            services.AddScoped<IGetPropertyImagesOutputPort, GetPropertyImagesPresenter>();
            return services;
        }
    }
}
