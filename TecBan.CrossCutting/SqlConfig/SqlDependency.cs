using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TecBan.CrossCutting.DependencyInjectionConfig;

namespace TecBan.CrossCutting.SqlConfig
{
    public static class SqlDependency
    {
        public static void AddSqlDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlConfiguration(configuration);
            services.ConfigureDependenciesRepositories();
        }
    }
}


