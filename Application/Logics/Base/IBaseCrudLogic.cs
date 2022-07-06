using System.Threading.Tasks;
using Domain.Models.Base;

namespace Application.Logics.Base;

public interface IBaseCrudLogic<TEntity>
    where TEntity : BaseEntity
{
    Task<TEntity[]> GetAll();
    Task Add(TEntity entity);
    Task Delete(int id);
}