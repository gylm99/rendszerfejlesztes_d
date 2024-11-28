using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace EstateSales.Backend.Context

{
    public class EstateMySqlIdentityContext : IdentityContext<EstateMySqlIdentityContext>
    {
        public EstateMySqlIdentityContext(DbContextOptions<EstateMySqlIdentityContext> options) : base(options)
        {
        }
    }
}
