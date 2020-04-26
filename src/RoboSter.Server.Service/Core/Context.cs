using System.Collections.Generic;
using RoboSter.Server.Service.Core.Descriptor;
using RoboSter.Server.Service.Core.Device.Entity;

namespace RoboSter.Server.Service.Core
{
    public class Context
    {
        public Context()
        {
            Stand = new StandDescriptor
            {
                StandId = "stand:first"
            };

            ManipulatorDevices = new List<ManipulatorDevice>
            {
                new ManipulatorDevice($"{Stand}:device:first"),
            };
        }
        
        public IList<ManipulatorDevice> ManipulatorDevices { get; }

        public StandDescriptor Stand { get; }
    }
}