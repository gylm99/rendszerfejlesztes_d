using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Repo.Base;
using EstateSales.Backend.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EstateSales.Backend.Controllers
{
    public class BaseController<TEntity>:ControllerBase where TEntity : class,IDbEntity<TEntity>, new()
    {
        protected readonly IBaseRepo<TEntity> _repo;
        public BaseController(IBaseRepo<TEntity> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordsToListAsync()
        {
            List<TEntity>? entity = new();
            if (_repo != null)
            {
                 entity=await _repo.GetAllAsync();
                return Ok(entity);
            }
            else
            {
                return BadRequest("Az adatok elérhetetlenek");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            TEntity? entity = new();
            if (_repo is not null)
            {
                entity=await _repo.GetByIdAsync(id);
                if(entity != null) { return Ok(entity); }
                else { return BadRequest("Az adat nem találhazó"); }
            }
            else
            {
                return BadRequest("Az adatot nem lehet elérni");
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateAsync(TEntity entity)
        {
            Responsee response = new Responsee();

            if(_repo is not null)
            {
                response = await _repo.UpdateAsync(entity);
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
            Responsee response = new Responsee();
            if (_repo is not null)
            {
                response = await _repo.DeleteAsync(id);
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
        public async Task<IActionResult> InsertStudentAsync(TEntity entity)
        {
            Responsee response = new Responsee();
            if (entity is not null)
            {
                response = await _repo.CreateAsync(entity);
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
