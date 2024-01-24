using MediatR;
using Sistem.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Commands.Client
{
    public class ClientUpdateCommand : IRequest<ClientDto>
    {
        public Guid Id { get; set; }
        public string? User { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
