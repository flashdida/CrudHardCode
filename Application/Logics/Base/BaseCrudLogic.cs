using System.Threading.Tasks;
using Domain.Model.Base;
using Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Logics.Base
{
    public class BaseCrudLogic<TEntity>: IBaseCrudLogic<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _db;
        protected readonly DbSet<TEntity> Sourse;

        public BaseCrudLogic(AppDbContext db)
        {
            _db = db;
            Sourse = db.Set<TEntity>();
        }

        public async Task<TEntity[]> GetAll() => await Sourse.ToArrayAsync();

        public async Task Add(TEntity entity)
        {
            Sourse.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await Sourse.
                FirstOrDefaultAsync(entity => entity.Id == id);
            if (entity != null)
            {
                Sourse.Remove(entity);
                await _db.SaveChangesAsync();
            }
        }
    }
}