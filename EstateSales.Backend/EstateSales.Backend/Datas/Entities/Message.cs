namespace EstateSales.Backend.Datas.Entities
{
    public class Message:IDbEntity<Message>
    {
        public Guid Id { get; set; }
        public string SenderEmailAddress { get; set; }
        public string Content {  get; set; }
        public DateTime CreatedAt { get; set; }
        public bool HasId => Id != Guid.Empty;

        public Message(Guid id, string senderEmailAddress, string content, DateTime createdAt)
        {
            Id = id;
            Content = content;
            SenderEmailAddress = senderEmailAddress;
            CreatedAt = createdAt;
        }

        public Message()
        {
            Id = Guid.NewGuid();
            Content=String.Empty;
            SenderEmailAddress = String.Empty;
            CreatedAt = DateTime.Now;
        }
        public Message( string senderEmailAddress, string content, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            SenderEmailAddress = senderEmailAddress;
            Content = content;
            CreatedAt = createdAt;
        }



    }
}
