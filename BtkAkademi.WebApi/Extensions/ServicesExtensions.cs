using BtkAkademi.Business;
using BtkAkademi.Business.Concrete;
using BtkAkademi.DataAccess.Concrete;
using BtkAkademi.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademi.WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<BtkContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
