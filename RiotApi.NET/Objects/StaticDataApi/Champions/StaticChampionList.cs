using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticChampionList : StaticDataApiObject
    {
        [JsonProperty("keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, StaticChampion> Data { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
