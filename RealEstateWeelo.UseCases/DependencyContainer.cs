using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateWeelo.UseCasesPorts;
using RealEstateWeelo.UseCases;
using RealEstateWeelo.UseCases.Mappings;

namespace RealEstateWeelo.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<ICreatePropertyInputPort, CreatePropertyInteractor>();
            services.AddTransient<IGetPropertiesInputPort, GetPropertiesInteractor>();
            services.AddTransient<ICreatePropertyImageInputPort, CreatePropertyImageInteractor>();
            services.AddTransient<IGetPropertyImagesInputPort, GetPropertyImagesInteractor>();
            return services;
        }
    }
}
