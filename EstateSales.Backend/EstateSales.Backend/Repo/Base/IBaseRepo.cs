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
        Task<Response> CreateAsync(TEntity entity);
        Task<Response> UpdateAsync(TEntity entity);
        Task<Response> DeleteAsync(Guid id);
    }
}
