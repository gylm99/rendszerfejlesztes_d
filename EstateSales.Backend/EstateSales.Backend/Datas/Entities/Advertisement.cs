namespace EstateSales.Backend.Datas.Entities
{
    public class Advertisement :IDbEntity<Advertisement>
    {
       

        public Guid Id { get; set; } 
        public string Title { get; set; }=string.Empty;
        public int RoomNumber { get; set; }
        public string Description { get; set; }=string.Empty;
        public bool HasAirCondition { get; set; }=false;
        public bool HasGarage { get; set; } =false;
        public bool HasId => Id != Guid.Empty;

        public Advertisement(Guid id, string title, int roomNumber, string description, bool hasAirCondition, bool hasGarage)
        {
            Id = id;
            Title = title;
            RoomNumber = roomNumber;
            Description = description;
            HasAirCondition = hasAirCondition;
            HasGarage = hasGarage;
        }

        public Advertisement( string title, int roomNumber, string description, bool hasAirCondition, bool hasGarage)
        {
            Id = Guid.NewGuid();
            Title = title;
            RoomNumber = roomNumber;
            Description = description;
            HasAirCondition = hasAirCondition;
            HasGarage = hasGarage;
        }

        public Advertisement()
        {

            Id = Guid.NewGuid();
            Title = string.Empty;
            RoomNumber = 0;
            Description = string.Empty;
            HasAirCondition = false;
            HasGarage = false;
        }
    }
}
