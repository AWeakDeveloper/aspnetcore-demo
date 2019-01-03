using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Contoso.Data;
using Microsoft.EntityFrameworkCore;

namespace Contoso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var provider = scope.ServiceProvider;
                try
                {
                    var context = provider.GetRequiredService<ContosoContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(context);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An error occured: {e}");
                    throw;
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        }
    }
}