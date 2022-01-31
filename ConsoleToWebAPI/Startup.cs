using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureWebServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello from async response");
                });

                endpoints.MapGet("/new", async context =>
                {
                    await context.Response.WriteAsync("New endpoint reached");
                });

                endpoints.MapGet("/old", async context =>
                {
                    await context.Response.WriteAsync("OLD endpoint reached");
                });
            });
        }
    }
}
