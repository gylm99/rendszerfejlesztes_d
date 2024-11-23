using EstateSales.Backend.Datas.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public class IdentityContext<TDbContext> : IdentityDbContext<LoginUser> where TDbContext : DbContext
    {
        public IdentityContext(DbContextOptions<TDbContext> options) : base(options)
        {
        }
    }
}
