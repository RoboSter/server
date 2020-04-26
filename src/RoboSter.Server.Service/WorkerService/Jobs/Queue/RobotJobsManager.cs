using RoboSter.Server.Service.WorkerService.Jobs.RobotJob;

namespace RoboSter.Server.Service.WorkerService.Jobs.Queue
{
    public class RobotJobsManager : IRobotJobsManager
    {
        public RobotJobDescriptor<TO> PlanJob<T, TO>(TO options) 
            where T : IRobotJob<TO> 
            where TO : class
        {
            var descriptor = RobotJobDescriptor<TO>.New<T>(options);
            JobsQueue.Enqueue(descriptor);
            return descriptor;
        }
    }
}