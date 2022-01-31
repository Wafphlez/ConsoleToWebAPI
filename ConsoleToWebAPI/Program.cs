using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    internal class Program
    {
        // 1. Reconfigure Project
        // 2. Create Host Builder
        // 3. Configure Web Hosts
        //    Startup
        //      ConfigureServices
        //      Configure
        // 4. Routing

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHost =>
                {
                    webHost.UseStartup<Startup>();
                });
        }

    }
}
