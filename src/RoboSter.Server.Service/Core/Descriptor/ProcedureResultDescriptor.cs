using System;
using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Descriptor
{
    public class ProcedureResultDescriptor
    {
        [JsonProperty("id")]                   
        public Guid ProcedureId { get; set; }  
        
        [JsonProperty("error")]
        public ProcedureErrorDescriptor Error { get; set; }
    }
    
    public class ProcedureResultDescriptor<T> : ProcedureResultDescriptor
    {
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}