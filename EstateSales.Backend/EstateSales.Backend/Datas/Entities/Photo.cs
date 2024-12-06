using Google.Protobuf.WellKnownTypes;
using System.Text.Json.Serialization;

namespace EstateSales.Backend.Datas.Entities
{
    public class Photo :IDbEntity<Photo>
    {
        public Guid Id { get; set; }
        public string ImagePath { get; set; }

        public bool HasID=> Id!=Guid.Empty;

        //kapcs prop

        [JsonIgnore]
        public Advertisement? Advertisement { get; set; }
        public Guid? AdvertisementId { get; set; }

        public Photo(string name) { Id = Guid.NewGuid(); ImagePath = name; }
        public Photo ( string name, Guid advertisementId) 
        { Id = Guid.NewGuid();
          ImagePath = name;
            AdvertisementId = advertisementId;
            
        }
        public Photo ()
        {
            Id = Guid.NewGuid();
            ImagePath =string.Empty;
        }
    }
}
