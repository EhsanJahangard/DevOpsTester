using Newtonsoft.Json;
using System.Net;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Midlewares
{
    //With a Middleware Class by Convention
    public class MyExceptionHandler
    {
        private readonly RequestDelegate _next;

        public MyExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                if (ex.Message == "خطا در عملیات")
                {
                    var response = new BaseResponseDto
                    {
                        Message = "خطا در عملیات",
                        IsSuccess = false,
                        Status = HttpStatusCode.ServiceUnavailable
                    };

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    httpContext.Response.ContentType = "application/json";

                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                }
                else
                {
                    var response = new BaseResponseDto
                    {
                        Message = ex.Message + " * " + ex.StackTrace + " * " + ex.InnerException?.Message,
                        IsSuccess = false,
                        Status = HttpStatusCode.InternalServerError
                    };

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    httpContext.Response.ContentType = "application/json";

                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
                }

                return;
            }

        }
    }

    public static class MyExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseMyExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyExceptionHandler>();
        }
    }
}
