using RoboSter.Server.Service.Core.Descriptor;
using RoboSter.Server.Service.Core.Model;

namespace RoboSter.Server.Service.Core.Device.Entity
{
    public class ManipulatorDevice : DeviceBase
    {
        public ManipulatorDevice(string deviceId) : base(deviceId)
        { }

        public OperationDescriptor Grip(bool lockGrip) => new OperationDescriptor
        {
            DeviceId = DeviceId,
            OperationId = "grip",
            Parameters = new {grip = lockGrip}
        };

        public OperationDescriptor Move(Coordinates to) => new OperationDescriptor
        {
            DeviceId = DeviceId,
            OperationId = "move",
            Parameters = to
        };
    }
}