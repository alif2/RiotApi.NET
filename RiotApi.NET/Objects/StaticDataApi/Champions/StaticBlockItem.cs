using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticBlockItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
