using System.Threading;
using System.Threading.Tasks;

namespace RoboSter.Server.Service.WorkerService.Jobs.RobotJob
{
    public interface IRobotJob<T> where T : class
    {
        Task Execute(RobotJobDescriptor<T> descriptor, CancellationToken cancellationToken);
    }
}