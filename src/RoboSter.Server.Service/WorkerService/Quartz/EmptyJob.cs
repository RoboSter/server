using System.Threading.Tasks;
using Quartz;
using RoboSter.Utilities.Container;

namespace RoboSter.Server.Service.WorkerService.Quartz
{
    [PreventAutoRegistration]
    internal class EmptyJob : IJob
    {
        public Task Execute(IJobExecutionContext context) => Task.CompletedTask;
    }
}