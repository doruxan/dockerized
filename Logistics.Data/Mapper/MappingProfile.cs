using System;
using AutoMapper;
using Logistics.Data.Dtos;
using Logistics.Data.Entities;

namespace Logistics.Data.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BoxItemEntity, BoxItemDto>().ReverseMap();
        }
    }
}
