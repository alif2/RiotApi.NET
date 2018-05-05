using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public class StaticLevelTip
    {
        [JsonProperty("effect")]
        public IEnumerable<string> Effect { get; set; }

        [JsonProperty("label")]
        public IEnumerable<string> Label { get; set; }
    }
}
