using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class AdvertisementRepo<TDbContext> : BaseRepo<TDbContext, Advertisement>, IAdvertisementRepo where TDbContext:EstateContext
    {
        public AdvertisementRepo(TDbContext? dbContext) : base(dbContext)
        {
            
        }

        public async Task<List<Advertisement>>  AdvetisementByUser()
        {
         
            return await _dbSet!.SelectAll().Include(x => x.User).ToListAsync();
        }

        
    }
}
