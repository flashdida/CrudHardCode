using Application.Models;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings;

public class ProductAttributeValueProfile : Profile
{
    public ProductAttributeValueProfile()
    {
        CreateMap<ProductAttributeValue, ProductAttributeValueDto>()
            .ReverseMap();
    }
}