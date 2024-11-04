using EstateSales.Backend.Context;
using EstateSales.Backend.Datas.Entities;
using EstateSales.Backend.Responses;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Repo
{
    public class UserRepo :IUserRepo
    {
        private readonly EstateInMemoryContextcs _dbcontext;




        private async Task<Responsee> InsertNewItemAsync(User user)
        {
            Responsee response = new();
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


        public async Task<Responsee> UpdateAsync(User user)
        {
            Responsee response = new Responsee();
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

        public async Task<Responsee> InsertAsync(User user) 
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

        public async Task<Responsee> DeleteAsync(Guid id)
        {
            Responsee response = new Responsee();
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
