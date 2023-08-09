using MediatR;
using Sistem.Application.Commands.Client;
using Sistem.Application.Interfaces;
using Sistem.Domain.Impl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Services
{
    public class ClientAppServices : IClientAppService
    {
        private readonly IMediator _mediator;

        public ClientAppServices(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Creat(ClientCreateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Delete(ClientDeleteCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Update(ClientUpdateCommand command)
        {
            await _mediator.Send(command);
        }

        public  void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
