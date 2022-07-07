using Application.Logics.Base;
using AutoMapper;
using Domain.Models.Base;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingSystem.Controllers.Base;

[ApiController]
[Route("api/[controller]/[action]")]
public class BaseCrudController<TEntity, TEntityDto> : ControllerBase
    where TEntity : BaseEntity
{
    private readonly IBaseCrudLogic<TEntity> _logic;
    private readonly IMapper _mapper;

    public BaseCrudController(IBaseCrudLogic<TEntity> logic, IMapper mapper)
    {
        _logic = logic;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _logic.GetAll();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TEntityDto entityDto)
    {
        var entity = _mapper.Map<TEntity>(entityDto);

        await _logic.Add(entity);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _logic.Delete(id);
        return Ok();
    }
}