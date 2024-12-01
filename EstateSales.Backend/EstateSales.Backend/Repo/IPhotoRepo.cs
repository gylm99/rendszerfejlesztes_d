using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;

namespace EstateSales.Backend.Repo
{
    public interface IPhotoRepo
    {
        Task<Responsee> CreatePhotoAsync(Photo photo);
        Task<List<Photo>> GetPhotoByAdvertisementIdAsync(Guid advertisementId);
        public Task<int> GetTotalPhotoCountAsync();
    }
}
