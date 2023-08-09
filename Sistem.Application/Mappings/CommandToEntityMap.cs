using AutoMapper;
using Sistem.Application.Ajudas;
using Sistem.Application.Commands.Client;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem.Application.Mappings
{
    /// <summary>
    /// classe de mapeamento de obejto COMMAND para => ENTITY
    /// </summary>
    public class CommandToEntityMap : Profile
    {
        public CommandToEntityMap()
        {
            CreateMap<ClientCreateCommand, Client>()
                .AfterMap((Command, entity) =>
                {
                    
                    entity.Id = IdGenerator.GenerateNewId();
                    entity.CreatedAt = DateTime.Now;
                    entity.UpdatedAt = DateTime.Now;
                });

            CreateMap<ClientUpdateCommand, Client>()
                .AfterMap((Command, entity) => 
                {
                    entity.UpdatedAt = DateTime.Now;
                });
        }
    }
}
