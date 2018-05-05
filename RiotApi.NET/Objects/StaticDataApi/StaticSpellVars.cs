using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public class StaticSpellVars
    {
        [JsonProperty("ranksWith")]
        public string RanksWith { get; set; }

        [JsonProperty("dyn")]
        public string Dyn { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("coeff")]
        public IEnumerable<double> Coeff { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
