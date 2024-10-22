using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }

        [HttpGet]

        public async Task<IActionResult> SelectAllRecordsToListAsync()
        {
            List<User>? users = new();
            if (_userRepo != null)
            {
                 users=await _userRepo.GetAllAsync();
                return Ok(users);
            }
            else
            {
                return BadRequest("Az adatok elérhetetlenek");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            User? entity = new();
            if (_userRepo is not null)
            {
                entity=await _userRepo.GetByIdAsync(id);
                if(entity != null) { return Ok(entity); }
                else { return BadRequest("Az adat nem találhazó"); }
            }
            else
            {
                return BadRequest("Az adatot nem lehet elérni");
            }
        }
    }
}
