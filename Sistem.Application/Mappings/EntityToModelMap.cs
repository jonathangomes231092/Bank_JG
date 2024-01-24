using AutoMapper;
using MySqlX.XDevAPI;
using Sistem.Application.Models;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
