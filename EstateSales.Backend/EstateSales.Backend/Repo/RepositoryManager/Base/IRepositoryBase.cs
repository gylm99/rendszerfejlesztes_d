using EstateSales.Backend.Responses;
using System.Linq.Expressions;

namespace EstateSales.Backend.Repo.RepositoryManager.Base
{
    public interface  IRepositoryBase<T>
    {
        
        
        Task<Responsee> CreateAsync(T entity);
        Task<Responsee> UpdateAsync(T entity);
        Task<Responsee> DeleteAsync(Guid id);
    }
}
