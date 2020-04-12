using Autofac;
using Quartz;
using Quartz.Impl;
using RoboSter.Server.Service.Core;
using RoboSter.Server.Service.Core.Device;
using RoboSter.Utilities.Configuration;
using RoboSter.Utilities.Container;

namespace RoboSter.Server.Service.Startup
{
    public static class ContainerConfig
    {
        public static void Configure(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<AppSettingsJsonConfig>().As<IConfig>();
            
            containerBuilder
                .ConfigureQuartz()
                .ConfigureForJobs();
            
            var module = new AutoRegistrationModule(typeof(GenericHostBuilder).Assembly);
            containerBuilder.RegisterModule(module);
        }

        private static ContainerBuilder ConfigureQuartz(this ContainerBuilder builder)
        {
            builder.RegisterType<StdSchedulerFactory>()
                .As<ISchedulerFactory>()
                .SingleInstance();
            
            return builder;
        }

        private static ContainerBuilder ConfigureForJobs(this ContainerBuilder builder)
        {
            builder.RegisterType<Context>().AsSelf().SingleInstance();
            return builder;
        }
    }
}