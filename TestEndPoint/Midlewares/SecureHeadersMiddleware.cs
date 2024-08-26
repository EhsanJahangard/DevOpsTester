
namespace TestEndPoint.Midlewares
{
    public class SecureHeadersMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
