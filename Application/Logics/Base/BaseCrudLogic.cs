using System.Threading.Tasks;
using Domain.Models.Base;
using Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Logics.Base
{
    public class BaseCrudLogic<TEntity>: IBaseCrudLogic<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext _db;
        protected readonly DbSet<TEntity> Source;

        public BaseCrudLogic(AppDbContext db)
        {
            _db = db;
            Source = db.Set<TEntity>();
        }

        public async Task<TEntity[]> GetAll() => await Source.ToArrayAsync();

        public async Task Add(TEntity entity)
        {
            Source.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await Source.
                FirstOrDefaultAsync(entity => entity.Id == id);
            
            if (entity != null)
            {
                Source.Remove(entity);
                await _db.SaveChangesAsync();
            }
        }
    }
}