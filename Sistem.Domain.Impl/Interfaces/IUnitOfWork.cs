using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Interfaces
{
    /// <summary>
    /// interface oara unidade de trabalho do repositorio
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        void Begintransaction();
        void CommitTransaction();
        void RollbackTransaction();


        #region Repositórios

        public IClientRepository ClientRepository { get; }

        #endregion

    }
}
