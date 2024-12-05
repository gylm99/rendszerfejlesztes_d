using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using EstateSales.Backend.Responses;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class PhotoRepo<TDbContext> : IPhotoRepo where TDbContext : EstateContext
    {
        private readonly TDbContext _dbcontext;

        public PhotoRepo(TDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public async Task<Response> CreatePhotoAsync(Photo photo)
        {
           Response response = new Response();


            if (photo == null) 
            {
                response.AppendNewError("A fotó nemlétezik, nem lehet elmenteni!");
            }
            else {

                try
                {
                    if (_dbcontext is not null)
                    {
                        await _dbcontext.Photos.AddAsync(photo);
                        await _dbcontext.SaveChangesAsync();
                    }
                }
                catch (Exception ex) 
                {
                    response.AppendNewError($"A kep elmentese sikertelen: {ex.Message}");
                }
            }
            return response;
        }

        public async Task<List<Photo>> GetPhotoByAdvertisementIdAsync(Guid advertisementId)
        {
            return await _dbcontext.Photos.Where(photo=>photo.AdvertisementId==advertisementId).ToListAsync();
        }
        public async Task<int> GetTotalPhotoCountAsync()
        {
            return await _dbcontext.Photos.CountAsync();
                
                
                /*_dbSet
                .Include(a => a.Photos) // Betöltjük a képeket is
                .SelectMany(a => a.Photos) // Lapítjuk a hirdetés-fotó kapcsolatot
                .CountAsync(); // Megszámoljuk az összes fotót*/
        }
    }
}
