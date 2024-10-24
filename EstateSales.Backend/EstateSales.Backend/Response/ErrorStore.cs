namespace EstateSales.Backend.Response
{
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

        public void AppendNewError(string error)
        {
            Error = $"{Error}\n+{error}";
        }
    }
}
