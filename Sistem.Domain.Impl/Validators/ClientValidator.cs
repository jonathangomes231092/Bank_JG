using FluentValidation;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Validetors
{
    // classe de validação para a entidade RegisterClient
    public class ClientValidator : AbstractValidator<RegisterClient>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty()
               .WithMessage("Id obrigatório");

            RuleFor(x => x.User)
                .NotEmpty()
                .WithMessage("Nome obrigatório")
                .Length(6, 150)
                .WithMessage("Nome deve possuir de 6 a 150 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email obrigatório")
                .EmailAddress().WithMessage("Endereço de email invalido");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Digite sua senha");            
        }
    }
}
