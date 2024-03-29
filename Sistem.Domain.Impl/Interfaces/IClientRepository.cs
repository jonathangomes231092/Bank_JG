﻿using Sistem.Domain.Impl.Entities;
using Sistem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Domain.Impl.Interfaces
{
    //interface para repositorio de registro de cliente
    public interface IClientRepository : IRepository<RegisterClient, Guid>
    {
        RegisterClient GetByUser(string user);
        RegisterClient GetByEmail(string email);
    }
}
