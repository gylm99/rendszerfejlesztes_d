namespace EstateSales.Backend.Response
{
    public class ControllerResponse:ErrorStore
    {
        public Guid Id { get; set; }
        public bool IsSucces => !HasError;

        public ControllerResponse() : base() { }
    }
}
