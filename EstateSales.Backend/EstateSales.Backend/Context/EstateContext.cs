using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context

{
    public class EstateContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public EstateContext(DbContextOptions options) : base(options)
        {

        }
    }
}
