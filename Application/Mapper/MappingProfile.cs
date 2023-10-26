using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<WordType, WordTypeDto>()
            .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
            .ReverseMap();
    }
}