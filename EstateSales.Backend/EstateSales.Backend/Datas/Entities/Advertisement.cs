using System;

namespace EstateSales.Backend.Datas.Entities
{
    public class Advertisement :IDbEntity<Advertisement>
    {
       

        public Guid Id { get; set; } 
        public string Title { get; set; }=string.Empty;
        public double Price { get; set; }
        public double BaseArea { get; set; }
        public int RoomNumber { get; set; }
        public string Description { get; set; }=string.Empty;
        public int BuiltYear { get; set; }
        public string Confort {  get; set; }
        public int FloorLevel { get; set; }
        public int MainBuildingFloorLevel { get; set; }
        public bool HasElevator { get; set; }=false;
        public string Orientation { get; set; }

        // FOTOK tarolasa

        public List<string> PhotosPath { get; set; } = new List<string>();


        // backendhez szügséges propok
        public bool HasId => Id != Guid.Empty;

        //ab kapcsolat
        public Guid UserId { get; set; }
        public User User { get; set; }
      

        public Advertisement(Guid id, string title, double price, double baseArea,
            int roomNumber, string description, int builtYear, string confort, int floorLevel, 
            int mainBuildingFloorLevel, bool hasElevator, string orientation,List<string> photosPath)
        {
            Id = id;
            Title = title;
            Price = price;
            BaseArea = baseArea;
            RoomNumber = roomNumber;
            Description = description;
            BuiltYear = builtYear;
            Confort = confort;
            FloorLevel = floorLevel;
            MainBuildingFloorLevel = mainBuildingFloorLevel;
            HasElevator = hasElevator;
            Orientation = orientation;
            PhotosPath = photosPath;
        }

        public Advertisement(string title, double price, double baseArea, int roomNumber,
            string description, int builtYear, string confort, int floorLevel, int mainBuildingFloorLevel,
            bool hasElevator, string orientation,List<string> photosPath)
        {
            Id= Guid.NewGuid();
            Title = title;
            Price = price;
            BaseArea = baseArea;
            RoomNumber = roomNumber;
            Description = description;
            BuiltYear = builtYear;
            Confort = confort;
            FloorLevel = floorLevel;
            MainBuildingFloorLevel = mainBuildingFloorLevel;
            HasElevator = hasElevator;
            Orientation = orientation;
            PhotosPath = photosPath;
        }

        public Advertisement()
        {

            Id = Guid.NewGuid();
            Title = string.Empty;
            RoomNumber = 0;
            Description = string.Empty;
            BuiltYear = 0;
            Confort = string.Empty;
            FloorLevel = 0;
            MainBuildingFloorLevel = 0;
            HasElevator = false;
            Orientation = string.Empty;
            PhotosPath=new List<string>();

        }
    }
}
