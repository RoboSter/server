using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Descriptor
{
    public class StandDescriptor
    {
        [JsonProperty("standId", Required = Required.Always)]
        public string StandId { get; set; }

        public override string ToString()
        {
            return StandId;
        }
    }
}