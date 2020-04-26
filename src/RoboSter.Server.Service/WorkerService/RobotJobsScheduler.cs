using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Quartz;
using RoboSter.Server.Service.WorkerService.Jobs.Queue;
using RoboSter.Server.Service.WorkerService.Quartz;

namespace RoboSter.Server.Service.WorkerService
{
    public class RobotJobsScheduler : IRobotJobsScheduler
    {
        private readonly ILogger<RobotJobsScheduler> logger;

        public RobotJobsScheduler(ILogger<RobotJobsScheduler> logger)
        {
            this.logger = logger;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            while (true)
            {
                var descriptor = JobsQueue.Dequeue();
                if (descriptor == null) break;

                logger.LogInformation($"{nameof(IScheduler.ScheduleJob)} {descriptor}");

                await context.Scheduler.ScheduleJob(descriptor.ToJobDetail(),
                    TriggerBuilder.Create().StartNow().Build(),
                    context.CancellationToken);
            }
        }
    }
}