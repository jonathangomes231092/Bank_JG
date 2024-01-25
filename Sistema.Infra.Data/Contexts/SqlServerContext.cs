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

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_Usuarios;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }*/

        // construtor da superclasse (DbContext)
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions)
            : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }

        public DbSet<RegisterClient>? Clientes { get; set; }
    }
}
