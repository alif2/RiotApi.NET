using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public class StaticItemTree
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}
