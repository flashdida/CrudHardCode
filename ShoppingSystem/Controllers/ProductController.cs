using Application.Logics.Base;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IBaseCrudLogic<Product> _logic;

        public ProductController(IBaseCrudLogic<Product> logic)
        {
            _logic = logic;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _logic.GetAll();
            return Ok(products);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _logic.Add(product);
            return Ok();
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _logic.Delete(id);
            return Ok();
        }
    }
}
