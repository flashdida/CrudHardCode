using System.Threading.Tasks;

namespace Application.Logics.Base;

public interface IBaseCrudLogic<TEntity>
{
    Task<TEntity[]> GetAll();
    Task Add(TEntity entity);
    Task Delete(int id);

}