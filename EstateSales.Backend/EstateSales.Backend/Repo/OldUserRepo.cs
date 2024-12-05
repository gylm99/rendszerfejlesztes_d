using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;
using Microsoft.EntityFrameworkCore;
//Ez már nem releváns
namespace EstateSales.Backend.Repo
{
    public class OldUserRepo 
    {
        private readonly EstateInMemoryContext _dbcontext;




        private async Task<Response> InsertNewItemAsync(User user)
        {
            Response response = new();
            try
            {
                _dbcontext.Users.Add(user);
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(OldUserRepo)} osztály, {nameof(InsertNewItemAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{user} osztály hozzáadása az adatbázishoz nem sikerült!");
            }
            return response;
        }


        public async Task<Response> UpdateAsync(User user)
        {
            Response response = new Response();
            _dbcontext.ChangeTracker.Clear();
            _dbcontext.Entry(user).State = EntityState.Modified;
            try
            {
                await _dbcontext.SaveChangesAsync();
            }
           
            catch (Exception ex)
            {
               
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(OldUserRepo)} osztály, {nameof(UpdateAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{user} frissítése nem sikerült");
            }
            return response;
        }

        public async Task<Response> InsertAsync(User user) 
        {
            if (user.HasId)
            {
                return await UpdateAsync(user);
            }
            else
            {
                return await InsertNewItemAsync(user);
            }
        }
        




        public OldUserRepo(EstateInMemoryContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Response> DeleteAsync(Guid id)
        {
            Response response = new Response();
            User? userToDelete = await GetByIdAsync(id);
            if(userToDelete is null || userToDelete == default)
            {
                response.AppendNewError($"Az {id} jú felhasználó nem található");
                response.AppendNewError("A törlés sikertelen");
            }
            else
            {
                _dbcontext.ChangeTracker.Clear();
                _dbcontext.Entry(userToDelete).State = EntityState.Modified;
                await _dbcontext.SaveChangesAsync();
            }
            return response;
        }
    }
}
