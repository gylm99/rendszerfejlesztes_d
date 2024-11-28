using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public class EstateInMemoryContext:EstateContext
    {
        public EstateInMemoryContext(DbContextOptions<EstateInMemoryContext> options) : base(options)
            
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed(); //todo
        }
    }
}
