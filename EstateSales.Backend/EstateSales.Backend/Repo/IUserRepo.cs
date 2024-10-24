using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Response;

namespace EstateSales.Backend.Repo
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(Guid id);
        Task<ControllerResponse> InsertAsync(User user);
        Task<ControllerResponse> DeleteAsync(Guid id);
        Task<ControllerResponse> UpdateAsync(User user);
        
    }
}
