using Sistem.Application.Commands.Client;
using Sistem.Application.Models;

namespace Sistem.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        Task<ClientDto> Creat(ClientCreateCommand command);
        Task<ClientDto> Delete(ClientDeleteCommand command);
        Task<ClientDto> Update(ClientUpdateCommand command);
    }
}
