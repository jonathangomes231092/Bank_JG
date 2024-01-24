using FluentValidation.Results;
using Sistem.Domain.Impl.Validetors;
using Sistem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Entities
{
    public class RegisterClient : IEntity
    {
        //entidade de dominio
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //atributos
        private string? _User;
        private string? _email;
        private string? _Password;


        //propriedades,           
        public string? User { get => _User; set => _User = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Password { get => _Password; set => _Password = value; }

        public ValidationResult validationResult
            => new ClientValidator().Validate(this);
    }
}
