using RoboSter.Server.Service.WorkerService.Jobs.RobotJob;

namespace RoboSter.Server.Service.WorkerService.Jobs.Queue
{
    public interface IRobotJobsManager
    {
        RobotJobDescriptor<TO> PlanJob<T, TO>(TO options)
            where T : IRobotJob<TO>
            where TO : class;
    }
}