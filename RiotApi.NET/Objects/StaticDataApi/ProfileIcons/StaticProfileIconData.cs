using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.ProfileIcons
{
    public class StaticProfileIconData : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticProfileIconDetails> Data { get; set; }
    }
}
