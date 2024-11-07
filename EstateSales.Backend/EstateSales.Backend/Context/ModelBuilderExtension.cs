using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EstateSales.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>()
            {
                 new User("Mekk Elek", "mekk@mek.com", "mekmek", "+36/309025476"),
                    new User("Teszt Eszter", "teszt@teszt.com", "teszt", "+36-20-735-2742")
            };
            List<Advertisement> advertisements = new List<Advertisement>()
            {
              
            new Advertisement(  "Beautiful Apartment", 3,"A spacious apartment in the city center with modern amenities.",true,true  ),
            new Advertisement( "Cozy Studio Apartment", 1, "A comfortable studio in a quiet neighborhood, perfect for singles.", false, false),
            new Advertisement( "Luxury Penthouse Suite", 5, "A luxury penthouse with stunning city views, ideal for families or executives.", true, true),
             new Advertisement("Modern Loft", 2, "A stylish loft with open space design and close to all amenities.", true, false)
            };
           
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Advertisement>().HasData(advertisements);

          
        }
    }
}
