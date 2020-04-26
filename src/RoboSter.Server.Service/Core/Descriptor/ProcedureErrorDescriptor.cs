using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Descriptor
{
    public class ProcedureErrorDescriptor
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        
        [JsonProperty("errorId", Required = Required.Always)]
        public string ErrorId { get; set; }
    }
}