using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("3\n");
            await next(context);
            await context.Response.WriteAsync("4\n");
        }
    }
}
