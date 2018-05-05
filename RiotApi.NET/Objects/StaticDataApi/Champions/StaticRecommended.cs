using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticRecommended
    {
        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("blocks")]
        public IEnumerable<StaticBlock> Blocks { get; set; }

        [JsonProperty("champion")]
        public string Champion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("priority")]
        public bool Priority { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
