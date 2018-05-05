using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Realms
{
    public class StaticRealm
    {
        [JsonProperty("lg")]
        public string Lg { get; set; }

        [JsonProperty("dd")]
        public string Dd { get; set; }

        [JsonProperty("l")]
        public string L { get; set; }

        [JsonProperty("n")]
        public Dictionary<string, string> N { get; set; }

        [JsonProperty("profileiconmax")]
        public int ProfilelIconMax { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("v")]
        public string V { get; set; }

        [JsonProperty("cdn")]
        public string Cdn { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }
    }
}
