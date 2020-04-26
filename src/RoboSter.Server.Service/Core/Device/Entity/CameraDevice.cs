using RoboSter.Server.Service.Core.Descriptor;

namespace RoboSter.Server.Service.Core.Device.Entity
{
    public class CameraDevice : DeviceBase
    {
        public CameraDevice(string deviceId) : base(deviceId)
        {
        }

        public OperationDescriptor TakeImage()
        {
            return new OperationDescriptor
            {
                DeviceId = DeviceId,
                OperationId = "image"
            };
        }
    }
}