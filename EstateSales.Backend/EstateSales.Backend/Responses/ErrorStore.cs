namespace EstateSales.Backend.Responses
{

    //Controller Responsok
    public class ErrorStore
    {
        public string Error { get; set; } = string.Empty;
        public bool HasError => !string.IsNullOrEmpty(Error);
        public ErrorStore()
        {
            Error = string.Empty;
        }
        public void ClearErrorStrore()
        {
            Error = string.Empty;
        }
        public void ClearAndAddError(string error)
        {
            Error = error;
        }
        public Response SetNewError(string error)
        {
            Error = error;
            return (Response)this;
        }

        public void AppendNewError(string error)
        {
            Error = $"{Error}\n+{error}";
        }
    }
}
