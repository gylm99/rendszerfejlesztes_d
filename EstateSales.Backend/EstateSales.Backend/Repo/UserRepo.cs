using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Response;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class UserRepo :IUserRepo
    {
        private readonly EstateInMemoryContextcs _dbcontext;




        private async Task<ControllerResponse> InsertNewItemAsync(User user)
        {
            ControllerResponse response = new();
            try
            {
                _dbcontext.Users.Add(user);
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(UserRepo)} osztály, {nameof(InsertNewItemAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{user} osztály hozzáadása az adatbázishoz nem sikerült!");
            }
            return response;
        }


        public async Task<ControllerResponse> UpdateAsync(User user)
        {
            ControllerResponse response = new ControllerResponse();
            _dbcontext.ChangeTracker.Clear();
            _dbcontext.Entry(user).State = EntityState.Modified;
            try
            {
                await _dbcontext.SaveChangesAsync();
            }
           
            catch (Exception ex)
            {
               
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(UserRepo)} osztály, {nameof(UpdateAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{user} frissítése nem sikerült");
            }
            return response;
        }

        public async Task<ControllerResponse> InsertAsync(User user) 
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
        




        public UserRepo(EstateInMemoryContextcs dbcontext)
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

        public async Task<ControllerResponse> DeleteAsync(Guid id)
        {
            ControllerResponse response = new ControllerResponse();
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
