using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace RoboSter.Server.Service.Core.Descriptor
{
    public class ProcedureDescriptor
    {
        [CanBeNull]
        [JsonProperty("id")]
        public Guid? ProcedureId { get; set; }
        
        [JsonProperty("stand")]
        public StandDescriptor Stand { get; set; }

        [JsonProperty("operations")]
        public IList<OperationDescriptor> Operations { get; set; } 
    }
}