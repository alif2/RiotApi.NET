using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class MatchReference
    {
        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("champion")]
        public int Champion { get; set; }

        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
