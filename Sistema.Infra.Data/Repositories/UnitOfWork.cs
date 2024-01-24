using Microsoft.EntityFrameworkCore.Storage;
using Sistem.Domain.Impl.Interfaces;
using Sistema.Infra.Data.SqlServer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Infra.Data.SqlServer.Repositories
{
    // unidade de trabalho para acesso aos repositoruios
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerContext _sqlServerContext;
        
        public UnitOfWork(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        private IDbContextTransaction _dbContextTransaction;

        public void Begintransaction()
        {
            _dbContextTransaction = _sqlServerContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbContextTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _dbContextTransaction.Rollback();
        }

        public void Dispose()
        {
            _sqlServerContext.Dispose();
        }
        
        public IClientRepository ClientRepository => new ClientRepository(_sqlServerContext);
    }
}
