using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Quartz;
using Quartz.Spi;

namespace RoboSter.Server.Service.WorkerService.Quartz
{
    public class QuartzJobsWorker : IHostedService
    {
        private readonly ISchedulerFactory schedulerFactory;
        private readonly IJobFactory jobFactory;

        private IScheduler scheduler;

        public QuartzJobsWorker(ISchedulerFactory schedulerFactory,
            IJobFactory jobFactory)
        {
            this.schedulerFactory = schedulerFactory;
            this.jobFactory = jobFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            scheduler = await schedulerFactory.GetScheduler(cancellationToken);
            scheduler.JobFactory = jobFactory;

            await scheduler.ScheduleJob(BuildRobotJob(),
                BuildRobotJobTrigger(),
                cancellationToken);
            
            await scheduler.Start(cancellationToken);
        }

        private IJobDetail BuildRobotJob()
        {
            return JobBuilder.Create<RobotJobsScheduler>()
                .WithIdentity(typeof(RobotJobsScheduler).FullName)
                .WithDescription(typeof(RobotJobsScheduler).Name)
                .Build();
        }

        private ITrigger BuildRobotJobTrigger()
        {
            return TriggerBuilder
                .Create()
                .WithCronSchedule("0/5 * * * * ?")
                .WithIdentity($"{typeof(RobotJobsScheduler).FullName}.trigger")
                .WithDescription($"{typeof(RobotJobsScheduler).Name}.trigger")
                .Build();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return scheduler?.Shutdown(cancellationToken);
        }
    }
}