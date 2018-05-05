using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotApi.NET.Objects.StaticDataApi.LanguageStrings
{
    public class StaticLanguageStrings : StaticDataApiObject
    {
        [JsonProperty("data")]
        public Dictionary<string, string> Data { get; set; }
    }
}
