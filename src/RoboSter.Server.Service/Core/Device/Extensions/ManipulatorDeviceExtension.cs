using RoboSter.Server.Service.Core.Descriptor;
using RoboSter.Server.Service.Core.Device.Entity;
using RoboSter.Server.Service.Core.Model;

namespace RoboSter.Server.Service.Core.Device.Extensions
{
    public static class ManipulatorDeviceExtension
    {
        public static ProcedureDescriptor CreateReplaceProcedure(this ManipulatorDevice device,
            StandDescriptor stand,
            Coordinates from,
            Coordinates to)
        {
            return new ProcedureDescriptor
            {
                Stand = stand,
                Operations = new[]
                {
                    device.Move(from),
                    device.Grip(true),
                    device.Move(to),
                    device.Grip(false)
                }
            };
        }
    }
}