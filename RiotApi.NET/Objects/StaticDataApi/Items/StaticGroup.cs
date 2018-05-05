using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Items
{
    public class StaticGroup
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
