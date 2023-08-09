using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Interfaces
{
    public interface IValidator
    {
        //metodo para retonar o resultado de uma validação
        ValidationResult validationResult { get; }
    }
}
