namespace QuickSalesApp.WebApi.MiddleWare
{
    public class ValidationErrorDetails :ErrorStatusCode
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
