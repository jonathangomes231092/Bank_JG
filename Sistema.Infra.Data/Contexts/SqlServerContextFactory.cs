using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Infra.Data.SqlServer.Contexts
{
    /// <summary>
    /// classe para executar os comandos o MIGRATIONS do entityFramework
    /// </summary>
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            //return new SqlServerContext();
            return null;
        }
    }
}
