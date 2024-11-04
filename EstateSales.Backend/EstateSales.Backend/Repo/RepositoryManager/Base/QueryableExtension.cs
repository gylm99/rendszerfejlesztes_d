using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EstateSales.Backend.Repo.RepositoryManager.Base
{
    public static class QueryableExtension
    {
        public static IQueryable<TEntity> SelectAll<TEntity> (this DbSet<TEntity> query) where TEntity : class, IDbEntity<TEntity>, new()
        {
            return query;
        }

        public static IQueryable<TEntity> FindByCondition<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> expression) where TEntity : class, IDbEntity<TEntity>, new()
        {
            return query.Where(expression);
        }

        public static TEntity? GetById<TEntity>(this IQ)
    }
}
