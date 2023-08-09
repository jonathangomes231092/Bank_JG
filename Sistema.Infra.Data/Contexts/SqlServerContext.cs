using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sistem.Domain.Impl.Entities;
using Sistema.Infra.Data.SqlServer.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Infra.Data.SqlServer.Contexts
{
    //classe de contexto do entityFramework para o sqlServer
    public class SqlServerContext : DbContext
    {
        // contrutor da superclasse (DbContext)
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions)
            : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }

        public DbSet<Client>? ResgisterClients { get; set; }
    }
}
