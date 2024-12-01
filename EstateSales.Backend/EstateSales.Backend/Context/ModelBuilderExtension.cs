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
               new Advertisement{
                        Title = "Modern lakás a belvárosban",
                        Price = 45000000,
                        BaseArea = 75.5,
                        RoomNumber = 3,
                        Description = "Tágas, világos lakás remek közlekedéssel.",
                        BuiltYear = 2010,
                        Confort = "Luxus",
                        FloorLevel = 2,
                        MainBuildingFloorLevel = 4,
                        HasElevator = true,
                       Orientation = "Dél" },
               new Advertisement
               {
                    Title = "Családi ház kertvárosi övezetben",
                    Price = 85000000,
                    BaseArea = 120,
                    RoomNumber = 4,
                    Description = "Csendes környék, nagy kerttel.",
                    BuiltYear = 2005,
                    Confort = "Komfortos",
                    FloorLevel = 0,
                    MainBuildingFloorLevel = 1,
                    HasElevator = false,
                    Orientation = "Nyugat" },

               new Advertisement
                    {
                        Title = "Felújítandó lakás",
                        Price = 30000000,
                        BaseArea = 50,
                        RoomNumber = 2,
                        Description = "Kiváló befektetési lehetőség a belvárosban.",
                        BuiltYear = 1980,
                        Confort = "Alap",
                        FloorLevel = 3,
                        MainBuildingFloorLevel = 5,
                        HasElevator = false,
                        Orientation = "Észak"
                    },
               new Advertisement
                            {
                                Title = "Új építésű penthouse",
                                Price = 150000000,
                                BaseArea = 200,
                                RoomNumber = 5,
                                Description = "Luxus szintű lakás panorámás kilátással.",
                                BuiltYear = 2022,
                                Confort = "Extra luxus",
                                FloorLevel = 5,
                                MainBuildingFloorLevel = 5,
                                HasElevator = true,
                                Orientation = "Kelet-Dél"
                            }


            };

            List<Message> messages=new List<Message> {
                new Message("mirmur@gmail.com", "Szia Elek!\nÉrdekel a házad!", DateTime.Now),
                new Message("frakk@gmail.com", "Szia Eszter!\nÉrdekel a házad!", DateTime.Now)
            };
           
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Advertisement>().HasData(advertisements);
            modelBuilder.Entity<Message>().HasData(messages);
           

          
        }
    }
}
