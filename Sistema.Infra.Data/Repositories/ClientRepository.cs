using Microsoft.EntityFrameworkCore;
using Sistem.Domain.Impl.Entities;
using Sistem.Domain.Impl.Interfaces;
using Sistema.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Infra.Data.SqlServer.Repositories
{
    // classe de repositorio para registro
    public class ClientRepository : BaseRepository<RegisterClient, Guid>, IClientRepository
    {
        private readonly SqlServerContext _sqlServerContext;

        public ClientRepository(SqlServerContext sqlServerContext) 
            : base(sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public RegisterClient GetByEmail(string email)
            => _sqlServerContext.Clientes
                .AsNoTracking()
                .FirstOrDefault(x =>x.Email.Equals(email));

        public RegisterClient GetByUser(string user)
             => _sqlServerContext.Clientes
                .AsNoTracking()
                .FirstOrDefault(x => x.User.Equals(user));
        
    }
}
