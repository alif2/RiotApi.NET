using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects
{
    public class ShardStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_tag")]
        public string Region { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("locales")]
        public IEnumerable<string> Locales { get; set; }

        [JsonProperty("services")]
        public IEnumerable<Service> Services { get; set; }
    }
}
