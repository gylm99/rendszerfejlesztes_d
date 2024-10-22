using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class UserRepo :IUserRepo
    {
        private readonly EstateInMemoryContextcs _dbcontext;

        public UserRepo(EstateInMemoryContextcs dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
