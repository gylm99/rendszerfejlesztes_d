using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;

namespace EstateSales.Backend.Repo
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(Guid id);
        Task<Responsee> InsertAsync(User user);
        Task<Responsee> DeleteAsync(Guid id);
        Task<Responsee> UpdateAsync(User user);
        
    }
}
