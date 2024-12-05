namespace EstateSales.Backend.Responses
{
    public class Response:ErrorStore
    {
        public Response(string error)
        {
            Error = error;
        }
        public Response() : base() { }
        public Guid Id { get; set; }
        public bool IsSuccess => !HasError;

    }
}
