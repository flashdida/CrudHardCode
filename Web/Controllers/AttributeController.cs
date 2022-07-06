using Application.Logics.Base;
using Application.Models;
using AutoMapper;
using ShoppingSystem.Controllers.Base;
using Attribute = Domain.Models.Attribute;

namespace ShoppingSystem.Controllers;

public class AttributeController : BaseCrudController<Attribute, AttributeDto>
{
    public AttributeController(IBaseCrudLogic<Attribute> logic, IMapper mapper) : base(logic, mapper)
    {
    }
}