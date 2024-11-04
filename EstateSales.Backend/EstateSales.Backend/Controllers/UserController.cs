using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseController<User>
    {
        public UserController(IBaseRepo<User> repo) : base(repo)
        {
        }
    }
}
