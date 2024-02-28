using MediatR;
using Sistem.Application.Models;

namespace Sistem.Application.Commands.Client
{
    public class ClientCreateCommand : IRequest<ClientDto>
    {

        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
