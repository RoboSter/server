using Autofac;
using Utilities.Container;

namespace Service.Startup
{
    public static class ContainerConfig
    {
        public static void Configure(ContainerBuilder containerBuilder)
        {
            var module = new AutoRegistrationModule(typeof(GenericHostBuilder).Assembly);
            containerBuilder.RegisterModule(module);
        }
    }
}