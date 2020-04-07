using System;
using System.Threading;
using System.Threading.Tasks;
using Quartz;
using RoboSter.Server.Service.WorkerService.Quartz;

namespace RoboSter.Server.Service.WorkerService.Jobs.RobotJob
{
    public abstract class RobotJobBase<T> : IJob, IRobotJob<T> where T : class, new()
    {
        public abstract Task Execute(RobotJobDescriptor<T> descriptor, CancellationToken cancellationToken);

        public Task Execute(IJobExecutionContext context)
        {
            var contextDescriptor = context.JobDetail.JobDataMap.GetJobDescriptor<T>();

            if (contextDescriptor is null)
                throw new ArgumentException("Job descriptor is missing in JobDataMap");

            return Execute(contextDescriptor, context.CancellationToken);
        }
    }
}