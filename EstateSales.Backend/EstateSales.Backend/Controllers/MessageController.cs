using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : BaseController<Message>
    {
        public MessageController(IBaseRepo<Message> repo) : base(repo)
        {
        }
    }
}
