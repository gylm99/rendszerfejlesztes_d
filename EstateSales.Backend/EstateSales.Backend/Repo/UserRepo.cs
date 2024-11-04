using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;

namespace EstateSales.Backend.Repo
{
    public class UserRepo<TDbContext> : BaseRepo<TDbContext, User>, IUserRepo where TDbContext : EstateContext
    {
        public UserRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
