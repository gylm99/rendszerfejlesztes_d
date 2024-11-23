namespace EstateSales.Backend.Datas.Entities
{
    public class User : IDbEntity<User>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        public bool HasId => Id!=Guid.Empty;
        public ICollection<Advertisement> Advertisements { get; set; }
        public ICollection<Message> Messages { get; set; }  

        public User(Guid id, string name, string email, string password, string number)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Number = number;
        }

        public User(string name, string email, string password, string number)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            Number = number;
        }

        public User()
        {
            Id= new Guid();
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Number = string.Empty;
        }
    }
}
