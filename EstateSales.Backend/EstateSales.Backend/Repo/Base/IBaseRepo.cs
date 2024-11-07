using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;
using System.Linq.Expressions;

namespace EstateSales.Backend.Repo.Base
{
    public interface IBaseRepo<TEntity> where TEntity : class, IDbEntity<TEntity>, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<Responsee> CreateAsync(TEntity entity);
        Task<Responsee> UpdateAsync(TEntity entity);
        Task<Responsee> DeleteAsync(Guid id);
    }
}
