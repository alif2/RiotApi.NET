using Newtonsoft.Json;

namespace RiotApi.NET.Objects.MatchApi
{
    public class Rune
    {
        [JsonProperty("runeId")]
        public int RuneId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
