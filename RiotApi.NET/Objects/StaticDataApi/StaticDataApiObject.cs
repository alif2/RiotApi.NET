using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi
{
    public abstract class StaticDataApiObject
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
