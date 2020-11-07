using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIS_Production.Data.EF;
using SIS_Production.Utilities.Constants;

namespace SIS_Production.BackendApi.Extensions
{
    public static class ConfigureDbServicesExtensions
    {
        public static IServiceCollection ConfigureDbService(this IServiceCollection services, IConfiguration configuration)
        {
            //add DB Context, nen su dung Global Project de su dung chung
            services.AddDbContext<SisSqlDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(SystemConstants.SqlConnection)));


            services.AddDbContext<SisPgDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString(SystemConstants.PgConnection)));

            return services;
        }
    }
}
