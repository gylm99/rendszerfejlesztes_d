using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdvertisementController : BaseController<Advertisement>
    {
        public AdvertisementController(IBaseRepo<Advertisement> repo) : base(repo)
        {
        }
    }
}
