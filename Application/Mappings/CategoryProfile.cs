using Application.Models;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryDto>()
            .ReverseMap();
    }
}