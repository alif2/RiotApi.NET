using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.Runes
{
    public class StaticRuneList : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticRune> Data { get; set; }
    }
}
