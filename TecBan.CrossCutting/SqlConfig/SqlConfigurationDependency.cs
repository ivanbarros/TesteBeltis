using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace TecBan.CrossCutting.SqlConfig

{
    public static class SqlConfigurationDependency
    {
        public static void AddSqlConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(c =>
            {
                return new SqlConnection(configuration["sqlDb:connectionString"]);
            });
            services.AddScoped<IDbConnection>(c =>
            {
                var dbConnection = c.GetService<SqlConnection>();
                dbConnection.Open();

                return dbConnection;
            });


            services.AddScoped(c =>
            {
                return c.GetService<IDbConnection>().BeginTransaction();
            });
        }
    }
}