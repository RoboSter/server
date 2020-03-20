using Autofac;
using RoboSter.Utilities.Configuration;
using RoboSter.Utilities.Container;

namespace RoboSter.Server.Service.Startup
{
    public static class ContainerConfig
    {
        public static void Configure(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<AppSettingsJsonConfig>().As<IConfig>();
            
            var module = new AutoRegistrationModule(typeof(GenericHostBuilder).Assembly);
            containerBuilder.RegisterModule(module);
        }
    }
}