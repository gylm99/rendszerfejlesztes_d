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

        public async Task<Advertisement?> GetAdvertisementWithPhotosAsync(Guid advertisementId)
        {
            var advertisement= await _dbSet.Include(a => a.Photos) 
                .FirstOrDefaultAsync(a => a.Id == advertisementId);
            if (advertisement == null)
            {
                throw new InvalidOperationException("A hirdetés nem található az adatbázisban.");
            }
            return advertisement;
        }

        public async Task<List<Advertisement>> GetAllAdvertisementsWithPhotosAsync()
        {
            return await _dbSet
                .Include(a => a.Photos)
                .ToListAsync();
        }


        public async Task<List<Advertisement>> GetAdvertisementsByUserIdAsync(Guid userId)
        {
            return await _dbSet
                .Where(a => a.UserId == userId)
                .Include(a => a.Photos) 
                .ToListAsync();
        }




    }
}
