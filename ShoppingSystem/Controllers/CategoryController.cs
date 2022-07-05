using Application.Logics.Base;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly IBaseCrudLogic<Product> _logic;

        public CategoryController(IBaseCrudLogic<Product> logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _logic.GetAll();
            return Ok(categories);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddCategory(Product category)
        {
            await _logic.Add(category);
            return Ok();
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _logic.Delete(id);
            return Ok();
        }
    }
}
