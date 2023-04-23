﻿using AutoMapper;
using CRMobil.Data.Mapper;
using CRMobil.Entities.Cliente;

namespace CRMobil.Profiles
{
    public class CrmAutoProfile : Profile
    {
        public CrmAutoProfile() 
        {
            CreateMap<ClienteMapper, Cliente>();
            CreateMap<Cliente, ClienteMapper>();
        }
    }
}
