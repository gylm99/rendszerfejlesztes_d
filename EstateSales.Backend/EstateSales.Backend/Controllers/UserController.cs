using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo;
using EstateSales.Backend.Response;
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
            _userRepo = userRepo;
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


        [HttpPut]
        public async Task<IActionResult> UpdateAsync(User entity)
        {
            ControllerResponse response = new ControllerResponse();

            if(_userRepo is not null)
            {
                response = await _userRepo.UpdateAsync(entity);
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A felhasználó adatainak módosítása nem sikerült.");
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            else
            {
                response.ClearAndAddError("Az adatok frissítése nem lehetséges.");
                return BadRequest(response);
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudentAsync(Guid id)
        {
            ControllerResponse response = new ControllerResponse();
            if (_userRepo is not null)
            {
                response = await _userRepo.DeleteAsync(id);
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A felhasználó adatait nem sikerült frissíteni.");
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Nem sikerült a törlés.");
            return BadRequest(response);
        }


        [HttpPost]
        public async Task<IActionResult> InsertStudentAsync(User user)
        {
            ControllerResponse response = new ControllerResponse();
            if (user is not null)
            {
                response = await _userRepo.InsertAsync(user);
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az új adatok mentése nem lehetséges!");
            return BadRequest(response);
        }


    }
}
