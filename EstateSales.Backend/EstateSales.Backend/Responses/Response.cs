namespace EstateSales.Backend.Responses
{
    public class Responsee:ErrorStore
    {
        public Guid Id { get; set; }
        public bool IsSucces => !HasError;

        public Responsee() : base() { }
    }
}
