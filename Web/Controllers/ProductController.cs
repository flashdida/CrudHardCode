using Application.Logics.Base;
using Application.Models;
using AutoMapper;
using Domain.Models;
using ShoppingSystem.Controllers.Base;

namespace ShoppingSystem.Controllers
{
    public class ProductController : BaseCrudController<Product,ProductDto>
    {
        public ProductController(IBaseCrudLogic<Product> logic, IMapper mapper) : base(logic, mapper)
        {
        }
    }
}
