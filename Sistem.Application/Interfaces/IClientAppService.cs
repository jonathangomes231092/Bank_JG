using Sistem.Application.Commands.Client;
using Sistem.Application.Models;
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
        Task<ClientDto> Creat(ClientCreateCommand command);
        Task<ClientDto> Delete(ClientDeleteCommand command);
        Task<ClientDto> Update(ClientUpdateCommand command);
    }
}
