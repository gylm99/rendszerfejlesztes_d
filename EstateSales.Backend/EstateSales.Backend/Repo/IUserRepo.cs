using EstateSales.Backend.Datas.Entities;

namespace EstateSales.Backend.Repo
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllAsync();
        Task<User ?> GetByIdAsync(Guid id);
    }
}
