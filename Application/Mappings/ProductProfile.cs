using Application.Models;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>()
            .ReverseMap();
    }
}