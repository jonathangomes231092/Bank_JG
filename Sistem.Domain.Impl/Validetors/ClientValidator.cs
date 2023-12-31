﻿using FluentValidation;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Validetors
{
    // classe de validação para a entidade RegisterClient
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty()
               .WithMessage("Id obragatorio");

            RuleFor(x => x.User)
                .NotEmpty()
                .WithMessage("Nome obrigatorio")
                .Length(6, 150)
                .WithMessage("Nome deve possuir de 6 a 150 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email obrigatorio")
                .EmailAddress().WithMessage("Endereço de email invalido");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Digite sua senha");            
        }
    }
}
