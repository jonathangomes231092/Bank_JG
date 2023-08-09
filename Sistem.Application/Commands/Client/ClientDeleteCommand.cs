using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Commands.Client
{
    public class ClientDeleteCommand : IRequest
    {
        public int Id { get; set; }
    }
}
