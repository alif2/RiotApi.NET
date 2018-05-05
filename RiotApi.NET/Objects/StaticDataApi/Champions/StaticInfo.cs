using Newtonsoft.Json;

namespace RiotApi.NET.Objects.StaticDataApi.Champions
{
    public class StaticInfo
    {
        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("magic")]
        public int Magic { get; set; }
    }
}
