using AutoMapper;
using Sistem.Application.Models;
using Sistem.Domain.Impl.Entities;

namespace Sistem.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<RegisterClient, ClientDto>();
        }
    }
}
