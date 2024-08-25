using Newtonsoft.Json;
using System.Net;
using TestApplication.Dtos.Common;

namespace TestEndPoint.Midlewares
{
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
                //log 
                //throw ex;

                if (ex.Message == "خطا در عملیات")
                {
                    var res = new BaseResponseDto
                    {
                        Message = "خطا در عملیات",
                        IsSuccess = false,
                    };

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    httpContext.Response.ContentType = "application/json";

                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(res));
                }

                else
                {
                    var res = new BaseResponseDto
                    {
                        Message = ex.Message + "---" + ex.StackTrace + " ***" + ex.InnerException?.Message,
                        IsSuccess = false,
                    };

                    httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    httpContext.Response.ContentType = "application/json";

                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(res));
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
