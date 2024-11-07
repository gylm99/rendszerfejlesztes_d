using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;

namespace EstateSales.Backend.Repo
{
    public class AdvertisementRepo<TDbContext> : BaseRepo<TDbContext, Advertisement>, IAdvertisementRepo where TDbContext:EstateContext
    {
        public AdvertisementRepo(TDbContext? dbContext) : base(dbContext)
        {
            
        }

        
    }
}
