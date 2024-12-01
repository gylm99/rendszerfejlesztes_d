using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;

namespace EstateSales.Backend.Repo
{
    public interface IAdvertisementRepo:IBaseRepo<Advertisement>
    {
        Task<Advertisement?> GetAdvertisementWithPhotosAsync(Guid advertisementId);
        Task<List<Advertisement>> GetAllAdvertisementsWithPhotosAsync();
        //Task<int> GetTotalPhotoCountAsync();
    }
}
