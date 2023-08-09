using Microsoft.EntityFrameworkCore;
using Sistem.Domain.Impl.Interfaces;
using Sistema.Infra.Data.SqlServer.Contexts;
using Sistema.Infra.Data.SqlServer.Repositories;

namespace Bank_JG.Configurations
{
    public class RepositoryConfig
    {
        public static void AddRepositoryConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            var connectionString = builder.Configuration.GetConnectionString("BDClients");
            builder.Services.AddDbContext<SqlServerContext>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
