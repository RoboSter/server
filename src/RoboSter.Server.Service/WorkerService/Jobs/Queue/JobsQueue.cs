using System.Collections.Concurrent;
using JetBrains.Annotations;
using RoboSter.Server.Service.WorkerService.Jobs.RobotJob;

namespace RoboSter.Server.Service.WorkerService.Jobs.Queue
{
    internal static class JobsQueue
    {
        private static readonly ConcurrentQueue<RobotJobDescriptor> Jobs = new ConcurrentQueue<RobotJobDescriptor>();

        public static void Enqueue(RobotJobDescriptor descriptor) => Jobs.Enqueue(descriptor);

        [CanBeNull]
        public static RobotJobDescriptor Dequeue()
        {
            if (Jobs.IsEmpty) return null;

            return Jobs.TryDequeue(out var descriptor) ? descriptor : null;
        }
    }
}