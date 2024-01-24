using AutoMapper;
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
            CreateMap<ClientCreateCommand, RegisterClient>()
                .AfterMap((Command, entity) =>
                {
                    entity.Id = Guid.NewGuid();                 
                    entity.CreatedAt = DateTime.Now;
                    entity.UpdatedAt = DateTime.Now;
                });

            CreateMap<ClientUpdateCommand, RegisterClient>()
                .AfterMap((Command, entity) => 
                {
                    entity.UpdatedAt = DateTime.Now;
                });
        }
    }
}
