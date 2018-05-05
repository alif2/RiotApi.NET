using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class Mastery
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
