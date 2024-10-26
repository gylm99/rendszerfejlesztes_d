using EstateSales.Backend.Response;
using System.Linq.Expressions;

namespace EstateSales.Backend.Repo.RepositoryManager.Base
{
    public interface  IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<ControllerResponse> CreateAsync(T entity);
        Task<ControllerResponse> UpdateAsync(T entity);
        Task<ControllerResponse> DeleteAsync(Guid id);
    }
}
