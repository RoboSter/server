using JetBrains.Annotations;
using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Descriptor
{
    public class OperationDescriptor
    {
        [JsonProperty("device", Required = Required.Always)]
        public string DeviceId { get; set; }
        
        [JsonProperty("operationId", Required = Required.Always)]
        public string OperationId { get; set; }
        
        [CanBeNull]
        [JsonProperty("parameters")]
        public object Parameters { get; set; } 
    }
}