using EstateSales.Backend.Responses;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using EstateSales.Backend.Datas.Entities;

namespace EstateSales.Backend.Repo.Base
{
    public abstract class BaseRepo<TDbContext, TEntity> : IBaseRepo<TEntity>
        where TDbContext : DbContext
        where TEntity : class, IDbEntity<TEntity>, new()
    {
        private readonly DbContext? _dbContext;
        protected readonly DbSet<TEntity>? _dbSet;

        public BaseRepo(TDbContext? dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException(nameof(dbContext), "A DbContext nem lehet null.");
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>() ?? throw new ArgumentException($"A {nameof(TEntity)} adatbázis tábla nem elérhető!");
        }
        public Task<List<TEntity>> GetAllAsync() => _dbSet!.SelectAll().ToListAsync();

        public Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet!.SelectAll().FindByCondition(expression).ToListAsync();
        }


        public Task<TEntity?> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_dbSet!.SelectAll().GetById(id));
        }
        public async Task<Response> UpdateAsync(TEntity entity)
        {
            Response response = new();
            try
            {
                if (_dbContext is not null)
                {
                    _dbContext.ChangeTracker.Clear();
                    _dbContext.Entry(entity).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                    response.Id = entity.Id;
                    return response;
                }
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(UpdateAsync)} metódusban hiba keletkezett");
            response.AppendNewError($"{entity} frissítése nem sikerült!");
            return response;
        }
        public async Task<Response> DeleteAsync(Guid id)
        {
            Response response = new();

            TEntity? entityToDelete = _dbSet!.FindByCondition(e => e.Id == id).FirstOrDefault();

            if (entityToDelete is null || entityToDelete is not null && !entityToDelete.HasId)
            {
                if (entityToDelete is not null)
                    response.AppendNewError($"{entityToDelete.Id} idével rendelkező entitás nem található!");
                response.AppendNewError("Az entitás törlése nem sikerült!");
            }
            else
            {
                try
                {
                    if (entityToDelete is not null && _dbContext is not null)
                    {
                        _dbContext.ChangeTracker.Clear();
                        _dbContext.Entry(entityToDelete).State = EntityState.Deleted;
                        await _dbContext.SaveChangesAsync();
                        response.Id = entityToDelete.Id;
                        return response;
                    }
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                }
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(DeleteAsync)} metódusban hiba keletkezett");
            if (entityToDelete is not null)
                response.AppendNewError($"Az entitás id:{entityToDelete.Id}");
            response.AppendNewError($"Az entitás törlése nem sikerült!");
            return response;
        }
        public async Task<Response> CreateAsync(TEntity entity)
        {
            Response response = new();
            if (_dbSet is null)
            {
                response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
            }
            else
            {
                try
                {
                    if (_dbContext is not null)
                    {
                        _dbSet.Add(entity);
                        await _dbContext.SaveChangesAsync();
                        response.Id = entity.Id;
                        return response;
                    }
                }
                catch (Exception e)
                {
                    response.AppendNewError(e.Message);
                }
            }
            response.AppendNewError($"{nameof(BaseRepo<TDbContext, TEntity>)} osztály, {nameof(CreateAsync)} metódusban hiba keletkezett");
            response.AppendNewError($"{entity} osztály hozzáadása az adatbázishoz nem sikerült!");
            return response;
        }

    }
}
