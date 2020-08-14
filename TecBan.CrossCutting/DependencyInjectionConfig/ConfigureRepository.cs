using TecBan.Data.Repository;
using TecBan.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace TecBan.CrossCutting.DependencyInjectionConfig
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<IAtmRepository, AtmRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


        }
    }
}
