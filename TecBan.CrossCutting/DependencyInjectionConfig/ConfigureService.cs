using Microsoft.Extensions.DependencyInjection;
using TecBan.Domain.Service;
using TecBan.Domain.Interface;

namespace TecBan.CrossCutting.DependencyInjectionConfig
{
    public static class ConfigureService
    {
        public static void ConfigureDependenciesService(this IServiceCollection services)
        {
            services.AddScoped<IAtmService, AtmService>();
           
           
        }
    }
}
