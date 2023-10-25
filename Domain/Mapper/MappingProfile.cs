using AutoMapper;
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<WordType, WordTypeDto>()
            .ForMember(dest => dest.Description,
                opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Words,
                opt => opt.MapFrom(src => src.Words.Select(word => word.WordText)))
            .ReverseMap();
    }
}