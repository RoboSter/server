using System.IO;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace RoboSter.Server.Service.Startup
{
    public static class GenericHostBuilder
    {
        public static IHost Build(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureCommon()
                .ConfigureWeb()
                .ConfigureWorker()
                .Build();
        }

        private static IHostBuilder ConfigureCommon(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureAppConfiguration((context, configurationBuilder) =>
                {
                    var env = context.HostingEnvironment;
                    configurationBuilder
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                        .AddEnvironmentVariables();
                })
                .ConfigureContainer<ContainerBuilder>(ContainerConfig.Configure);
        }

        private static IHostBuilder ConfigureWorker(this IHostBuilder hostBuilder)
        {
            return hostBuilder;
        }

        private static IHostBuilder ConfigureWeb(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureWebHostDefaults(webHostBuilder =>
            {
                webHostBuilder
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<WebConfig>();
            });
        }
    }
}