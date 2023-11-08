using Domain.Entity;

namespace Domain.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        Task Update(Guid id, TEntity entity);
        Task Delete(int id);
    }
}
