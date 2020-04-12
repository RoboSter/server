namespace RoboSter.Server.Service.Core.Device.Entity
{
    public abstract class DeviceBase
    {
        protected DeviceBase(string deviceId)
        {
            DeviceId = deviceId;
        }
        
        public string DeviceId { get; }
    }
}