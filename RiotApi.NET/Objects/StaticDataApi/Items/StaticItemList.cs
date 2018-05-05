using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Items
{
    public class StaticItemList : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticItem> Data { get; set; }

        [JsonProperty("tree")]
        public IEnumerable<StaticItemTree> Tree { get; set; }

        [JsonProperty("groups")]
        public IEnumerable<StaticGroup> Groups { get; set; }
    }
}
