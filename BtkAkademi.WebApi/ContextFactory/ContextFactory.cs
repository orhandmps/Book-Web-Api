using BtkAkademi.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BtkAkademi.WebApi.ContextFactory
{
    public class ContextFactory : IDesignTimeDbContextFactory<BtkContext>
    {
        public BtkContext CreateDbContext(string[] args)
        {
            var Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BtkContext>()
                .UseSqlServer(Configuration.GetConnectionString("SqlConnection"));

            return new BtkContext(builder.Options);
        }
    }
}
