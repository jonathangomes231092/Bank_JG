using MediatR;
using Sistem.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Commands.Client
{
    public class ClientDeleteCommand : IRequest<ClientDto>
    {
        public Guid Id { get; set; }
    }
}
