using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticBlock
    {
        [JsonProperty("items")]
        public IEnumerable<StaticBlockItem> Items { get; set; }

        [JsonProperty("recMath")]
        public bool RecMath { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
