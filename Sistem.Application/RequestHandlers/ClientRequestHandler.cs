using AutoMapper;
using FluentValidation;
using MediatR;
using Sistem.Application.Commands.Client;
using Sistem.Application.Interfaces;
using Sistem.Application.Models;
using Sistem.Domain.Impl.Entities;
using Sistem.Domain.Impl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.RequestHandlers
{
    /// <summary>
    /// componente de Mediatr para processamento dos COMMANDS ( CREATE, UPDATE e DELETE)
    /// </summary>
    public class ClientRequestHandler : IDisposable,
        IRequestHandler<ClientCreateCommand, ClientDto>,
        IRequestHandler<ClientDeleteCommand, ClientDto>,
        IRequestHandler<ClientUpdateCommand, ClientDto>
    {
        private readonly IClientDomainService _clientDomainService;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ClientRequestHandler(IClientDomainService clientDomainService,
            IMediator mediator,
            IMapper mapper)
        {
            _clientDomainService = clientDomainService;
            _mediator = mediator;
            _mapper = mapper;
        }

        //create
         public async Task<ClientDto> Handle(ClientCreateCommand request, CancellationToken cancellationToken)
         {
             // capiturando dados do cliente
             var client = _mapper.Map<RegisterClient>(request);

             // executando a validação da entidade cliente
             if (!client.validationResult.IsValid)
                 throw new ValidationException(client.validationResult.Errors);

             await _clientDomainService.CreateAsync(client);

             return _mapper.Map<ClientDto>(client);
         }

         //Update
         public async Task<ClientDto> Handle(ClientUpdateCommand request, CancellationToken cancellationToken)
         {
             // capiturando dados do cliente
             var client = _mapper.Map<RegisterClient>(request);

             // executando a validação da entidade cliente
             if (!client.validationResult.IsValid)
                 throw new ValidationException(client.validationResult.Errors);

             await _clientDomainService.UpdateAsync(client);

            return _mapper.Map<ClientDto>(client);
        }

         // delete
         public async Task<ClientDto> Handle(ClientDeleteCommand request, CancellationToken cancellationToken)
         {

             var client = await _clientDomainService.GetByIdAsync(request.Id);

             await _clientDomainService.DeleteAsync(client);

            return _mapper.Map<ClientDto>(client);
        }

        public void Dispose()
        {
            _clientDomainService.Dispose();
        }
    }
}
