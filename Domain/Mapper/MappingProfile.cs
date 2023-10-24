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

        CreateMap<Word, WordDto>()
            .ForMember(dest => dest.WordText,
                opt => opt.MapFrom(src => src.WordText))
            .ForMember(opt => opt.WordTypeDto,
                opt => opt.MapFrom(src => src.WordType))
            .ReverseMap();
        
    }
}