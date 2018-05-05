using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Maps
{
    public class StaticMapData : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticMapDetails> Data { get; set; }
    }
}
