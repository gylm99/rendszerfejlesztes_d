using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public class EstateInMemoryIdentityContext : IdentityContext<EstateInMemoryIdentityContext>
    {
        public EstateInMemoryIdentityContext(DbContextOptions<EstateInMemoryIdentityContext> options) : base(options)
        {
        }
    }
}
