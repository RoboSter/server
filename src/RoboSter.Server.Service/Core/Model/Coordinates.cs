using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Model
{
    public class Coordinates
    {
        [JsonProperty("x")]
        public virtual int X { get; set; }
        
        [JsonProperty("y")]
        public virtual int Y { get; set; }
    }
}