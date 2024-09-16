using Newtonsoft.Json;

namespace CleanArchitecture.WebApi.Middleware;

public sealed class ErrorResult : ErrorStatusCode
{
    public string Message { get; set; }
}
public class ErrorStatusCode
{
    public int StatusCode{ get; set; }
    override public string ToString() => JsonConvert.SerializeObject(this);
}
public sealed class ValidationErrorDetails :ErrorStatusCode
{ 
    public IEnumerable<string> Errors { get; set; } 
}

