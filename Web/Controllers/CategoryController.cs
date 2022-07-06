using Application.Logics.Base;
using Application.Models;
using AutoMapper;
using Domain.Models;
using ShoppingSystem.Controllers.Base;

namespace ShoppingSystem.Controllers
{
    public class CategoryController : BaseCrudController<Category, CategoryDto>
    {
        public CategoryController(IBaseCrudLogic<Category> logic, IMapper mapper) : base(logic, mapper)
        {
        }
    }
}
