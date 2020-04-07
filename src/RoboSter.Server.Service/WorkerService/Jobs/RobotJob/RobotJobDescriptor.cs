using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace RoboSter.Server.Service.WorkerService.Jobs.RobotJob
{
    public class RobotJobDescriptor
    {
        public RobotJobDescriptor(Type jobType, object options)
        {
            Guid = Guid.NewGuid();
            JobType = jobType;
            Options = options;
        }

        public Guid Guid { get; }
        
        [JsonIgnore]
        public Type JobType { get; }

        public object Options { get; protected set; }

        
        [JsonProperty("JobType")]
        private string JobTypeName => JobType.Name;
        
        public override string ToString()
        {
            return $"Job: {JobType.Name}. Guid: {Guid}.";
        }
        
    }

    public class RobotJobDescriptor<T> : RobotJobDescriptor where T : class
    {
        public static RobotJobDescriptor<T> New<TJ>(T options) where TJ : IRobotJob<T>
        {
            return new RobotJobDescriptor<T>(typeof(TJ), options);
        }
        
        private RobotJobDescriptor(Type jobType, T options) : base(jobType, options)
        {
        }

        public new T Options
        {
            get => base.Options as T;
            set => base.Options = value;
        }
    }
}