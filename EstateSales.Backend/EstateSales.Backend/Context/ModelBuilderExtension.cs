using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>()
            {
                 new User("Mekk Elek", "mekk@mek.com", "mekmek", 422),
                    new User("Teszt Eszter", "teszt@teszt.com", "teszt", 10)
            };
            modelBuilder.Entity<User>().HasData(users);

          
        }
    }
}
