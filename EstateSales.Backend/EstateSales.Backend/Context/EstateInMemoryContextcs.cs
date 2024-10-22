using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public class EstateInMemoryContextcs:EstateContext
    {
        public EstateInMemoryContextcs(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed(); //todo
        }
    }
}
