using Application.Models;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings;

public class AttributeProfile : Profile
{
    public AttributeProfile()
    {
        CreateMap<Attribute, AttributeDto>()
            .ReverseMap();
    }
}