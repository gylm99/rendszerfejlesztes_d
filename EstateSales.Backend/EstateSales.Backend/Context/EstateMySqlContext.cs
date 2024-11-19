using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public class EstateMySqlContext : EstateContext
    {
        public EstateMySqlContext(DbContextOptions<EstateMySqlContext> options) : base(options)
        {
        }
             protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    
    }
}
