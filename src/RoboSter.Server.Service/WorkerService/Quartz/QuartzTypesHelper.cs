using System.Collections.Generic;
using Quartz;
using RoboSter.Server.Service.WorkerService.Jobs.RobotJob;

namespace RoboSter.Server.Service.WorkerService.Quartz
{
    public static class QuartzTypesHelper
    {
        public static IJobDetail ToJobDetail(this RobotJobDescriptor descriptor)
        {
            return JobBuilder.Create(descriptor.JobType)
                .WithDescription(descriptor.ToString())
                .WithIdentity(descriptor.Guid.ToString())
                .UsingJobData(descriptor.ToDataMap())
                .Build();
        }

        private static JobDataMap ToDataMap(this RobotJobDescriptor descriptor)
        {
            IDictionary<string, object> jobData = new Dictionary<string, object>
            {
                {nameof(RobotJobDescriptor), descriptor}
            };

            return new JobDataMap(jobData);
        }

        public static RobotJobDescriptor<T> GetJobDescriptor<T>(this JobDataMap jobDataMap) where T : class
        {
            return jobDataMap.Get(nameof(RobotJobDescriptor)) as RobotJobDescriptor<T>;
        }
    }
}