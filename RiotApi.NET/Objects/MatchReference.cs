using Newtonsoft.Json;

namespace RiotApi.NET.Objects
{
    public class MatchReference
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("platformId")]
        public string Platform { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("champion")]
        public int Champion { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}