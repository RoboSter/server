using RoboSter.Server.Service.Core.Descriptor;
using RoboSter.Server.Service.Core.Device.Entity;

namespace RoboSter.Server.Service.Core.Device.Extensions
{
    public static class CameraDeviceExtension
    {
        public static ProcedureDescriptor CreateTakeImageProcedure(this CameraDevice device, StandDescriptor stand)
        {
            return new ProcedureDescriptor
            {
                Stand = stand,
                Operations = new[] {device.TakeImage()},
            };
        }
    }
}