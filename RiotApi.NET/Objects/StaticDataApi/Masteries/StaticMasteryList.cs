using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Masteries
{
    public class StaticMasteryList : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticMastery> Data { get; set; }

        [JsonProperty("tree")]
        public StaticMasteryTree Tree { get; set; }
    }
}
