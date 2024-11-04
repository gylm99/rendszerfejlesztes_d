namespace EstateSales.Backend.Datas.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Email { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}
