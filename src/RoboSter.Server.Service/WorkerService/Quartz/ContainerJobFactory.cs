using System;
using Autofac;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Spi;

namespace RoboSter.Server.Service.WorkerService.Quartz
{
    internal class ContainerJobFactory : IJobFactory
    {
        private readonly ILogger<ContainerJobFactory> logger;
        private readonly IComponentContext context;

        public ContainerJobFactory(ILogger<ContainerJobFactory> logger, IComponentContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            try
            {
                return context.Resolve(bundle.JobDetail.JobType) as IJob;
            }
            catch (Exception e)
            {
                logger.LogError("Job resolve error", e);
                throw;
            }
        }

        public void ReturnJob(IJob job)
        {
        }
    }
}