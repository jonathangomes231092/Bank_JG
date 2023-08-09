using Sistem.Application.Commands.Client;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        Task Creat(ClientCreateCommand command);
        Task Delete(ClientDeleteCommand command);
        Task Update(ClientUpdateCommand command);
    }
}
